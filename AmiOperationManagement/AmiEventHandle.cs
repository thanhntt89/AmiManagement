
using AmiOperationManagement;
using AmiOperationManagement.CustomeUserControl;
namespace AmiOperationManagement
{
    public delegate void OperationEventHandle();
    public delegate void RecieveMessageEventHandle(string topic, byte[] payload);
    public delegate void SendDataEventHandle(string data);
    public delegate void ConnectionStatusHandle(bool status);
    public delegate void DisplayProgressBarHandle(bool isDisplay);
    public delegate void StopSendingHandle();
    public delegate void SendProgressBarValueHandle(int maxValue, int value); 
    public delegate void EvnTreeViewNodeSeletedHandle(NodeCustom nodeSelected);
}
