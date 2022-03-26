using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using DevComponents.AdvTree;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ModemTypeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiOperationManagement.Connection
{
    public partial class UCClientConnection : UserControlBase
    {
        public RecieveMessageEventHandle RecieveMessageEvent;
        public ConnectionStatusHandle ConnectionStatusEvent;

        // Danh sách client
        private List<ClientConnection> clientList = new List<ClientConnection>();
        private ClientConnection clientConnection = null;

        private ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
        private ServerTableAdapter serverTableAdapter = new ServerTableAdapter();

        private ModemTypeDataSet.ModemTypeDataTable modemTypeDataTable = new ModemTypeDataSet.ModemTypeDataTable();
        private ModemTypeTableAdapter modemTypeTableAdapter = new ModemTypeTableAdapter();

        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();

        private CommandLineDataSet.CommandLineDataTable messageTestDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();

        //private string subscribeTopic = string.Empty;
        // Thứ tự các đối số trong cấu trúc bản tin 
        private const int modemIndex = 0;
        private const int meterIndex = 1;
        private const int dcuIndex = 2;


        public UCClientConnection()
        {
            InitializeComponent();
        }

        private void LoadSubcribeTestTopic()
        {
            try
            {
                int rst = this.commandLineTableAdapter.FillByCommandType(this.messageTestDataTable, Constant.TestMessage);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - LoadSubcribeTestTopic. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadServer()
        {
            try
            {
                int rst = this.serverTableAdapter.FillByTypeAndStatus(this.serverDataTable, Constant.Gateway, true);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu thông tin máy chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tvServerList.ImageList = imageList;

                NodeCustom nodeRoot = new NodeCustom(Constant.SERVER_SAOVIET_TEXT);
                nodeRoot.ImageIndex = 0;
                nodeRoot.ImageExpandedIndex = 0;
                nodeRoot.CheckBoxVisible = true;
                tvServerList.Nodes.Add(nodeRoot);
                nodeRoot.ExpandVisibility = eNodeExpandVisibility.Hidden;
                nodeRoot.Checked = true;

                foreach (ServerDataSet.ServerRow item in this.serverDataTable)
                {
                    NodeCustom node = new NodeCustom(item.ServerName);
                    node.CheckBoxVisible = true;
                    node.ImageIndex = 2;
                    node.ImageExpandedIndex = 2;
                    node.Checked = true;
                    node.ServerAddress = item.ServerIP;
                    node.ServerName = item.ServerName;
                    node.UserName = item.UserName;
                    node.Password = item.Password;
                    node.Port = int.Parse(item.Port);

                    tvServerList.Nodes[0].Nodes.Add(node);
                }

                tvServerList.ExpandAll();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - LoadServer. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateServerStatus(string serverName, string serverAddress, bool status)
        {
            MethodInvoker methodInvokerDelegate = delegate()
            {
                // Update gateways connection status
                UserSession.GatewayList.UpdateGatewayStatus(serverAddress, status);

                foreach (NodeCustom item in tvServerList.Nodes[0].Nodes)
                {
                    if (item.Checked && item.ServerAddress.Equals(serverAddress) && serverName.Equals(item.ServerName))
                    {
                        item.ImageIndex = status ? 1 : 2;
                        item.ImageExpandedIndex = status ? 1 : 2;
                        break;
                    }
                }
            };

            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void LoadMeterType()
        {
            try
            {
                int rst = this.meterTypeTableAdapter.Fill(this.meterTypeDataTable);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu loại đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MeterTypeDataSet.MeterTypeDataTable dataSoure = new MeterTypeDataSet.MeterTypeDataTable();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - LoadMeterType. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadModemType()
        {
            try
            {
                int rst = this.modemTypeTableAdapter.FillByIsUsed(this.modemTypeDataTable);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - LoadModemType. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConnectGateway()
        {
            UserSession.GatewayList.Clear();
            this.clientList.Clear();
            int count = 0;
            foreach (NodeCustom item in this.tvServerList.Nodes[0].Nodes)
            {
                if (item.Checked)
                    count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Bạn chưa chọn server để kết nối", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tvServerList.Nodes[0].CheckBoxVisible = false;

            foreach (NodeCustom item in this.tvServerList.Nodes[0].Nodes)
            {
                item.CheckBoxVisible = false;

                if (!item.Checked)
                    continue;
                GatewayInfo gtInfor = new GatewayInfo();
                this.clientConnection = new ClientConnection();
                gtInfor.ServerName = item.ServerName;
                gtInfor.BrokerAddress = item.ServerAddress;
                gtInfor.BrokerPort = item.Port;
                gtInfor.UserName = item.UserName;
                gtInfor.Password = item.Password;
                gtInfor.ClientName = UserSession.UserName + "-" + Environment.MachineName + "-" + DateTime.Now.ToString("dd-MM-yyyy-HH:mm:ss");
                this.clientConnection.GatewaysInfo = gtInfor;

                this.clientConnection.receiveMessageEvent += GetMessage;
                this.clientConnection.ConnectStatusEvent += clientConnection_ConnectStatusEvent;
                try
                {
                    // Update gateways connection status
                    UserSession.GatewayList.Add(new GatewayEntity { GetWayIP = item.ServerAddress });

                    this.clientConnection.Connect();
                    this.clientConnection.SubscribeMessage(this.CreateTopicTestMessage());
                    this.clientList.Add(this.clientConnection);

                    // Log system histories
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ServerConnect);
                    UserSession.Action = SystemResource.UserFunction_Action_Connect_Gateway;
                    UserSession.Notes = "Kết nối đến gateway: " + gtInfor.BrokerAddress;
                    this.InsertHistories();
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - ConnectGateway. Chi tiết:", ex);
                    btnDisconnect_Click(null, null);
                    MessageBox.Show("Lỗi: Không kết nối được với gateways. Bạn hãy kiểm tra lại thông tin kết nối tới server. Chi tiết lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetMessage(string topic, byte[] message)
        {
            if (this.RecieveMessageEvent != null)
                this.RecieveMessageEvent(topic, message);
        }

        private string CreateTopicTestMessage()
        {
            string topicTest = string.Empty;
            var pattern = @"{(.*?)}";

            foreach (ModemTypeDataSet.ModemTypeRow item in modemTypeDataTable.Rows)
            {
                foreach (MeterTypeDataSet.MeterTypeRow meterType in meterTypeDataTable.Rows)
                {
                    foreach (CommandLineDataSet.CommandLineRow topic in messageTestDataTable.Rows)
                    {
                        var matches = Regex.Matches(topic.Topic, pattern);
                        var totalMatchCount = matches.Count;
                        object[] par = new object[totalMatchCount];

                        for (int i = 0; i < totalMatchCount; i++)
                        {
                            switch (i)
                            {
                                case modemIndex:
                                    par[i] = item.ModemType;
                                    break;
                                case meterIndex:
                                    par[i] = meterType.MeterCode;
                                    break;
                                default:
                                    break;
                            }
                        }

                        topicTest += String.Format(topic.Topic, par) + ";";
                    }
                }
            }

            try
            {
                topicTest = topicTest.Remove(topicTest.Length - 1, 1);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - CreateTopicTestMessage. Chi tiết:", ex);
                MessageBox.Show("Lỗi không gửi được lệnh nhận bản tin: " + topicTest, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return topicTest;
        }

        private void clientConnection_ConnectStatusEvent(string serverName, string serverAddress, bool isConnected, string message)
        {
            try
            {
                MethodInvoker methodInvokerDelegate = delegate()
                {
                    //btnSubscribe.Enabled = isConnected;
                    btnDisconnect.Enabled = isConnected;
                    btnConnect.Enabled = !isConnected;

                    panelConnectionStatus.BackColor = isConnected ? Color.LawnGreen : Color.Red;
                    if (!isConnected)
                    {
                        //btnSubscribe.Text = Constant.SubScribeText;
                    }

                    this.UpdateServerStatus(serverName, serverAddress, isConnected);

                    if (this.ConnectionStatusEvent != null)
                        this.ConnectionStatusEvent(isConnected);
                };

                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCClientConnection - clientConnection_ConnectStatusEvent. Chi tiết:", ex);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            foreach (var item in this.clientList)
            {
                // Ngắt kết nối các client trước khi connect lại
                item.Disconnect();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ServerConnect);
                UserSession.Action = SystemResource.UserFunction_Action_Connect_Gateway_Disconnect;
                UserSession.Notes = "Ngắt kết nối gateway: " + item.GatewaysInfo.BrokerAddress;
                this.InsertHistories();
            }

            tvServerList.Nodes[0].CheckBoxVisible = true;
            foreach (NodeCustom item in this.tvServerList.Nodes[0].Nodes)
            {
                item.CheckBoxVisible = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.ConnectGateway();
        }

        private void UCClientConnection_Load(object sender, EventArgs e)
        {
            this.LoadServer();
            this.LoadMeterType();
            this.LoadModemType();
            this.LoadSubcribeTestTopic();
        }

        /// <summary>
        /// Thoát khỏi hệ thống
        /// </summary>
        public void ApplicationExit()
        {
            foreach (var item in clientList)
            {
                item.UnSubscribeMessage();
                item.Disconnect();
            }
        }

        public void PublishMessage(string topic, byte[] playload)
        {
            if (btnConnect.Enabled)
            {
                //MessageBox.Show("Không có kết nối đến gateway. Gửi dữ liệu đi không thành công.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gửi bản tin đến tất cả các client trong hệ thống
            foreach (var item in clientList)
            {
                item.PublishMessage(topic, playload);
            }
        }

        public void SubscribeMessage(string subscribeTopic)
        {
            // Unsubcribe
            foreach (var item in clientList)
            {
                item.SubscribeMessage(subscribeTopic);
            }
        }

        public void UnSubcribeMessage()
        {
            // Unsubcribe
            foreach (var item in clientList)
            {
                item.UnSubscribeMessage();
            }
        }

        private void tvServerList_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (!tvServerList.Nodes[0].CheckBoxVisible)
                return;

            tvServerList.Nodes[0].CheckBoxThreeState = false;
            if (e.Node.Text.Equals(Constant.SERVER_SAOVIET_TEXT))
            {
                foreach (NodeCustom item in tvServerList.Nodes[0].Nodes)
                {
                    item.Checked = e.Node.Checked;
                }
            }
            else
            {
                int count = 0;
                foreach (NodeCustom item in tvServerList.Nodes[0].Nodes)
                {
                    if (item.Checked)
                        count++;
                }

                if (count == tvServerList.Nodes[0].Nodes.Count)
                    tvServerList.Nodes[0].Checked = true;
                else
                {
                    tvServerList.Nodes[0].CheckBoxThreeState = true;
                    tvServerList.Nodes[0].CheckState = CheckState.Indeterminate;
                }
            }
        }

        private void UCClientConnection_SizeChanged(object sender, EventArgs e)
        {
            this.tvServerList.Size = new Size(this.Size.Width - 7, this.Size.Height - panelConnectionStatus.Height - btnConnect.Height - 20);
        }
    }
}
