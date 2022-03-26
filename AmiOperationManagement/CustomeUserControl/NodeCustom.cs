using DevComponents.AdvTree;

namespace AmiOperationManagement.CustomeUserControl
{
    public class NodeCustom : Node
    {
        public NodeCustom(string text)
        {
            this.Text = text;
        }
        // ErrorId
        public long ErrorId { get; set; }
        public string ErrorCode { get; set; }

        // Thông tin server
        public string ServerAddress { get; set; }
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }

        // Thông tin bản tin subscribe
        public string Topic { get; set; }
        public string MessageType { get; set; }

        // MesurementPointGroupInfor
        public long NodeId { get; set; }
        public string NodeType { get; set; }
        public bool IsExpanded { get; set; }
    }
}
