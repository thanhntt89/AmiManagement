
namespace AmiOperationLib
{
    public class GatewayInfo
    {
        public string ServerName { get; set; }
        public string ClientName { get; set; }
        public string BrokerAddress { get; set; }
        public int BrokerPort { get; set; }
        public int OpenWritePort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Topics { get; set; }
        public int TimeOut { get; set; }
        public int QoS { get; set; }

        public int AmiType { get; set; }
    }
}
