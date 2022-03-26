using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using System;
using System.Windows.Forms;
using System.Linq;
using OperationDTO.AmiOperationDataSet.ModemTypeDataSetTableAdapters;
using System.Text.RegularExpressions;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using System.Collections.Generic;
using System.Drawing;
using AmiOperationManagement.CustomeUserControl;
using DevComponents.AdvTree;
using System.Text;
using AmiOperationManagement.Resources;
using System.ComponentModel;
using AmiOperationManagement.Main;
using System.Threading.Tasks;
using System.Threading;
namespace AmiOperationManagement
{
    public partial class UCCommander : UserControlBase
    {
        private AutoResetEvent timeOutEvent;

        public SendDataEventHandle SubscribeMessageEvent;
        public OperationEventHandle UnSubscribeMessageEvent;
        public RecieveMessageEventHandle PublishMessageEvent;

        private List<string> topicSubscribe = new List<string>();
        private List<string> dcuList = new List<string>();
        private int maxSubscribeTopic = 0;
        private int subscribeTopicIndex = 0;

        private string subscribeTopic = string.Empty;
        // Thứ tự các đối số trong cấu trúc bản tin 
        private const int modemIndex = 0;
        private const int meterIndex = 1;
        private const int dcuIndex = 2;
        private bool isDisconnect = false;

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();

        private CommandLineDataSet.CommandLineDataTable messageTestDataTable = new CommandLineDataSet.CommandLineDataTable();

        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
        private ServerTableAdapter serverTableAdapter = new ServerTableAdapter();

        private ModemTypeDataSet.ModemTypeDataTable modemTypeDataTable = new ModemTypeDataSet.ModemTypeDataTable();
        private ModemTypeTableAdapter modemTypeTableAdapter = new ModemTypeTableAdapter();

        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();

        private BackgroundWorker bgwCreatedTopic;

        public UCCommander()
        {
            InitializeComponent();
            ucDcuController.PublishMessageEvent += PublishMessage;
            ucProgressBar.DisplayProgressBarEvent += ucDcuController_DisplayProgressBarEvent;
            ucProgressBar.StopSendingEvent += StopSending;
        }

        private void StopSending()
        {
            if (bgwCreatedTopic != null && bgwCreatedTopic.IsBusy)
            {
                this.bgwCreatedTopic.CancelAsync();
            }
        }

        void ucDcuController_SendProgressBarValueEvent(int maxValue, int value)
        {
            ucProgressBar.SetValue(maxValue, value);
        }

        void ucDcuController_DisplayProgressBarEvent(bool isDisplay)
        {
            MethodInvoker methodInvokerDelegate = delegate()
                    {
                        splitContainer1_Panel1_SizeChanged(null, null);
                        ucProgressBar.Visible = isDisplay;
                        splitContainer1_Panel1_SizeChanged(null, null);
                        ucProgressBar.SetTile(Constant.StopSendingText);
                    };
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void UCCommander_Load(object sender, EventArgs e)
        {
            LoadSubScribeTopics();
            LoadMeterType();
            LoadModemType();
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
                int index = 0;
                foreach (MeterTypeDataSet.MeterTypeRow item in this.meterTypeDataTable.Rows)
                {
                    var row = dataSoure.NewMeterTypeRow();

                    row.MeterTypeName = item.MeterTypeName;
                    row.MeterCode = item.MeterCode;

                    dataSoure.Rows.InsertAt(row, index);
                    index++;
                }

                var newRow = dataSoure.NewMeterTypeRow();
                newRow.MeterCode = string.Empty;
                newRow.MeterTypeName = Constant.MeterTypeAllText;

                dataSoure.Rows.InsertAt(newRow, 0);
                cboMeterType.DataSource = dataSoure;
                cboMeterType.DisplayMember = dataSoure.MeterTypeNameColumn.ColumnName;
                cboMeterType.ValueMember = dataSoure.MeterCodeColumn.ColumnName;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load METER. Chi tiết lỗi: ", ex);
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
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load MODEM. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadSubScribeTopics()
        {
            // Tự động set vị trí cho chức năng đăng ký bản tin nhận
            panelModem_ExpandedChanged(null, null);

            // Không load lại dữ liệu bản tin nếu trạng thái gateway đang kết nối
            if (btnSubscribe.Text.Equals(Constant.UnSubscribeText))
                return;

            tvTopics.Nodes.Clear();
            try
            {
                int rst = this.commandLineTableAdapter.FillByCommandType(this.commandLineDataTable, Constant.SubscribeMessage);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu bản tin đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NodeCustom nodeRoot = new NodeCustom(Constant.SERVER_TOPIC_TEXT);
                nodeRoot.ImageIndex = 0;
                nodeRoot.ImageExpandedIndex = 0;
                nodeRoot.CheckBoxVisible = true;
                tvTopics.Nodes.Add(nodeRoot);
                nodeRoot.ExpandVisibility = eNodeExpandVisibility.Hidden;

                nodeRoot.Checked = true;

                foreach (CommandLineDataSet.CommandLineRow item in this.commandLineDataTable)
                {
                    NodeCustom node = new NodeCustom(item.CommandName);
                    node.CheckBoxVisible = true;
                    node.Checked = true;
                    node.ImageIndex = 2;
                    node.ImageExpandedIndex = 2;

                    node.MessageType = item.Topic.Split('/')[3];
                    node.Topic = item.Topic;

                    tvTopics.Nodes[0].Nodes.Add(node);
                }

                tvTopics.ExpandAll();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load bản tin subscribe. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadSubcribeTestTopic()
        {
            try
            {
                int rst = this.commandLineTableAdapter.FillByCommandType(this.messageTestDataTable, Constant.TestMessage);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu bản tin đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load bản tin subscribe. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clientConnection_ConnectStatusEvent(bool isConnected)
        {
            try
            {
                MethodInvoker methodInvokerDelegate = delegate()
                {
                    btnSubscribe.Enabled = isConnected;
                    ucDcuController.SetPublishEnable(isConnected);
                    panelConnectionStatus.BackColor = isConnected ? Color.LawnGreen : Color.Red;

                    if (!isConnected)
                    {
                        this.isDisconnect = true;
                        this.StopSending();

                        if (btnSubscribe.Text.Equals(Constant.SubScribeText))
                            return;
                        btnSubscribe_Click(null, null);
                    }
                };

                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
            }
            catch { }

        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            this.SubScribe();
        }

        private void SubScribe()
        {
            if (!btnSubscribe.Text.Equals(Constant.SubScribeText))
            {
                // Unsubcribe
                if (this.UnSubscribeMessageEvent != null)
                    this.UnSubscribeMessageEvent();

                foreach (NodeCustom item in tvTopics.Nodes[0].Nodes)
                {
                    item.ImageIndex = 2;
                    item.ImageExpandedIndex = 2;
                    item.CheckBoxVisible = true;
                }
                this.btnSubscribe.Image = global::AmiOperationManagement.Properties.Resources.message16;
                ucDcuController.SetDcuInputStatus(true);
                btnSubscribe.Text = Constant.SubScribeText;
                cboMeterType.Enabled = true;
                txtDcu.ReadOnly = false;
                tvTopics.Nodes[0].CheckBoxVisible = true;
                return;
            }

            int count = 0;
            foreach (NodeCustom item in this.tvTopics.Nodes[0].Nodes)
            {
                if (item.Checked)
                    count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản tin để nhận dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDcu.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Chưa nhập mã modem để thao tác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelModem.Expanded = true;
                txtDcu.Focus();
                return;
            }

            if (this.timeOutEvent == null)
                this.timeOutEvent = new AutoResetEvent(false);

            this.topicSubscribe.Clear();
            tvTopics.Nodes[0].CheckBoxVisible = false;
            subscribeTopic = string.Empty;
            this.subscribeTopicIndex = 0;
            this.isDisconnect = false;
            // Get dculist to subscribe message
            dcuList = txtDcu.Text.Split('\n').Distinct().ToList();


            txtDcu.ReadOnly = true;
            btnSubscribe.Enabled = false;
            cboMeterType.Enabled = false;
            this.btnSubscribe.Image = global::AmiOperationManagement.Properties.Resources.message16;

            //  Get danh sach ca ban tin sub
            foreach (MeterTypeDataSet.MeterTypeRow meterType in meterTypeDataTable.Rows)
            {
                foreach (NodeCustom node in tvTopics.Nodes[0].Nodes)
                {
                    node.ImageExpandedIndex = 2;
                    node.ImageIndex = 2;
                    node.Editable = false;
                    node.CheckBoxVisible = false;
                    if (!node.Checked)
                        continue;

                    node.ImageIndex = 1;
                    node.ImageExpandedIndex = 1;

                    var query = UserSession.SystemSubTopic.GetItem(cboMeterType.SelectedIndex <= 0 ? meterType.MeterCode : cboMeterType.SelectedValue.ToString(), node.MessageType);
                    if (query != null)
                    {
                        this.topicSubscribe.Add(query.Topic);
                    }
                }

                if (cboMeterType.SelectedIndex > 0)
                    break;
            }

            this.maxSubscribeTopic = this.dcuList.Count * this.topicSubscribe.Count;

            this.ucDcuController_SendProgressBarValueEvent(this.maxSubscribeTopic, 0);
            ucDcuController_DisplayProgressBarEvent(true);


            if (bgwCreatedTopic == null)
            {
                bgwCreatedTopic = new BackgroundWorker();
                bgwCreatedTopic.RunWorkerCompleted += bgwCreatedTopic_RunWorkerCompleted;
                bgwCreatedTopic.DoWork += bgwCreatedTopic_DoWork;
                bgwCreatedTopic.ProgressChanged += bgwCreatedTopic_ProgressChanged;
                bgwCreatedTopic.WorkerReportsProgress = true;
                bgwCreatedTopic.WorkerSupportsCancellation = true;
            }

            bgwCreatedTopic.RunWorkerAsync();
        }

        void bgwCreatedTopic_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.ucDcuController_SendProgressBarValueEvent(this.maxSubscribeTopic, e.ProgressPercentage);
        }

        void bgwCreatedTopic_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string dcu in dcuList)
            {
                foreach (string topic in this.topicSubscribe)
                {
                    MethodInvoker methodInvokerDelegate = delegate()
                        {
                            subscribeTopic += String.Format(topic, dcu) + ";";
                            txtCommandText.AppendText("\nSUBSCRIBE TOPICS: " + String.Format(topic, dcu));
                        };
                    if (this.InvokeRequired)
                        this.Invoke(methodInvokerDelegate);
                    else
                        methodInvokerDelegate();

                    this.timeOutEvent.WaitOne(2);

                    this.subscribeTopicIndex++;
                    bgwCreatedTopic.ReportProgress(this.subscribeTopicIndex);

                    if (bgwCreatedTopic.CancellationPending)
                    {
                        e.Cancel = true;
                        bgwCreatedTopic.ReportProgress(0);
                        return;
                    }
                }

                if (bgwCreatedTopic.CancellationPending)
                {
                    e.Cancel = true;
                    bgwCreatedTopic.ReportProgress(0);

                    return;
                }
            }

            bgwCreatedTopic.ReportProgress(this.maxSubscribeTopic);

            try
            {
                subscribeTopic = subscribeTopic.Remove(subscribeTopic.Length - 1, 1);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi gửi bản tin. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi không gửi được lệnh nhận bản tin: " + subscribeTopic, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void bgwCreatedTopic_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                tvTopics.Nodes[0].CheckBoxVisible = true;
                foreach (NodeCustom node in tvTopics.Nodes[0].Nodes)
                {
                    node.ImageExpandedIndex = 2;
                    node.ImageIndex = 2;
                    node.CheckBoxVisible = true;
                }

                if (this.isDisconnect)
                {
                    btnSubscribe.Enabled = false;
                    MessageBox.Show("Mất kết nối đến server, gửi yêu cầu đã bị dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnSubscribe.Enabled = true;
                    MessageBox.Show("Tiền trình đã dừng xử lý, gửi yêu cầu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtCommandText.Clear();
                cboMeterType.Enabled = true;
                txtDcu.ReadOnly = false;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Lỗi trong quán trình xử lý, gửi yêu cầu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Subscribe
                if (this.SubscribeMessageEvent != null)
                    this.SubscribeMessageEvent(subscribeTopic);
                btnSubscribe.Enabled = true;
                btnSubscribe.Text = Constant.UnSubscribeText;
                this.btnSubscribe.Image = global::AmiOperationManagement.Properties.Resources.message_outline16;
            }

            ucDcuController_DisplayProgressBarEvent(false);
            
            bgwCreatedTopic.Dispose();
            bgwCreatedTopic = null;
            this.subscribeTopic = string.Empty;
        }

        public async void GetMessage(string topic, byte[] playload)
        {
            if (!this.IsReceiveData)
                return;

            if (!topic.Contains(Constant.TestTopic))
            {
                Invoke(new Action(() =>
                    {

                        string temp = string.Empty;

                        if (chkIsHex.Checked)
                        {
                            temp = ConvertUtil.BytesToHexString(playload);
                        }
                        else
                        {
                            if (topic.Contains(Constant.WarningTopic))
                            {
                                byte obis = playload[2];

                                switch (obis)
                                {
                                    // Lỗi flash
                                    case 0x01:
                                        temp = Constant.FlashErorText;
                                        break;
                                    // Thay cơng tơ
                                    case 0x02:
                                        temp = Constant.WarningChangeMeterText;
                                        break;
                                    // Mất kết nối với công tơ
                                    case 0x03:
                                        temp = Constant.WarningDcuDisconnectMeter;
                                        break;
                                    // Đọc sai
                                    case 0x04:
                                        temp = Constant.WarningMeterDataWrongText;
                                        break;
                                    // Lỗi dây
                                    case 0x08:
                                        temp = Constant.WarningErrorLineText;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                foreach (byte item in playload)
                                {
                                    byte[] a = new byte[1];
                                    a[0] = item;
                                    if (item > 32 && item < 125 || item == 20)
                                    {
                                        temp += Encoding.ASCII.GetString(a);
                                    }
                                    else
                                    {
                                        temp += ConvertUtil.BytesToHexString(a);
                                    }                                    
                                }
                            }
                        }

                        ucDcuController.DisplayMessageSubscribe(topic, playload);

                        txtCommandText.AppendText("SUBSCRIBE MESSAGE\nTIME: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "\nTOPIC: " + topic + "\nPLAYLOAD: " + temp + "\n\n");
                        MemoryManagement.MinimizeMemory();
                    }));
            }

            Thread.Sleep(2);
        }

        private void PublishMessage(string topic, byte[] playload)
        {
            // Gửi bản tin đến tất cả các client trong hệ thống
            if (this.PublishMessageEvent != null)
                this.PublishMessageEvent(topic, playload);
            Invoke(new Action(() =>
                {
                    txtCommandText.AppendText("USER REQUEST\nTIME: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "\nPUBLISH TOPICS: " + topic + "\nPLAYLOAD: " + ConvertUtil.BytesToHexString(playload) + "\n\n");
                    txtCommandText.ScrollToCaret();
                    MemoryManagement.MinimizeMemory();
                }));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCommandText.Text = string.Empty;
            MemoryManagement.MinimizeMemory();
        }

        private void tvTopics_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (!tvTopics.Nodes[0].CheckBoxVisible)
                return;

            tvTopics.Nodes[0].CheckBoxThreeState = false;
            if (e.Node.Text.Equals(Constant.SERVER_TOPIC_TEXT))
            {
                foreach (NodeCustom item in tvTopics.Nodes[0].Nodes)
                {
                    item.Checked = e.Node.Checked;
                }
            }
            else
            {
                int count = 0;
                foreach (NodeCustom item in tvTopics.Nodes[0].Nodes)
                {
                    if (item.Checked)
                        count++;
                }

                if (count == tvTopics.Nodes[0].Nodes.Count)
                    tvTopics.Nodes[0].Checked = true;
                else
                {
                    tvTopics.Nodes[0].CheckBoxThreeState = true;
                    tvTopics.Nodes[0].CheckState = CheckState.Indeterminate;
                }
            }
        }

        private void panelModem_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (this.panelModem.Expanded)
                this.panelModem.Size = new Size(this.panelModem.Size.Width, this.txtCommandText.Height + 27 - (ucProgressBar.Visible ? ucProgressBar.Height : 0));
        }

        private void ucDcuController_Load(object sender, EventArgs e)
        {
            // Log người dùng
            UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
            UserSession.Action = SystemResource.User_Action_View;

            UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
            this.InsertHistories();
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            panelModem_ExpandedChanged(null, null);
        }

        private void mnPaste_Click(object sender, EventArgs e)
        {
            string[] dcuList = Clipboard.GetText().Split(';');
            for (int i = 0; i < dcuList.Count(); i++)
            {
                txtDcu.AppendText(dcuList[i] + "\n");
            }
        }

    }
}
