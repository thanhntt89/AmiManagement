using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using System;
using System.Text;
using System.Windows.Forms;

namespace AmiOperationManagement.Deployment
{
    public partial class ViewMessageDetail : DevComponents.DotNetBar.Metro.MetroForm
    {
        private MessageCollection messageCollection = new MessageCollection();

        public ViewMessageDetail(MessageCollection messageCollection, string topics)
        {
            InitializeComponent();
            this.messageCollection = messageCollection;
            lblTopic.Text = topics;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewDetailMessage_Load(object sender, EventArgs e)
        {
            LoadMessage();
        }

        private void LoadMessage()
        {
            var messageList = this.messageCollection.GetMessageByTopic(lblTopic.Text);

            foreach (MessageEntity item in messageList.MessageList)
            {
                dtgMessage.Rows.Add(item.ServerTime == DateTime.MinValue ? string.Empty : item.ServerTime.ToString("dd-MM-yyyy HH:mm:ss"), item.ReceiveTime, item.Index);
            }

            dtgMessage.Rows[0].Selected = true;
            this.ViewByIndex(0);
        }

        private void ViewByIndex(int rowIndex)
        {
            txtCommandText.Clear();
            if (rowIndex == -1)
                return;
            int messageIndex = int.Parse(dtgMessage.Rows[rowIndex].Cells[IndexCol.Index].Value.ToString());

            string messageTime = dtgMessage.Rows[rowIndex].Cells[clMessageTime.Index].Value == null ? string.Empty : dtgMessage.Rows[rowIndex].Cells[clMessageTime.Index].Value.ToString();

            MessageEntity message = this.messageCollection.GetMessageByMessageIndex(messageIndex);

            if (message == null)
                return;

            string temp = string.Empty;

            string topic = message.Topic;

            byte[] playload = message.Data;

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

            txtCommandText.AppendText("MESSAGE TIME: " + messageTime + "\nTOPIC: " + topic + "\nPLAYLOAD: " + temp + "\n\n");
        }

        private void dtgMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ViewByIndex(e.RowIndex);
        }

        private void ViewMessageDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            MemoryManagement.MinimizeMemory();
        }
    }
}
