// Author: Phung Văn Đông
// Email: dongpv@saovietgroup.com.vn
// Mobile: 098 364 3739
// Created date: Wednesday, June 29, 2016 9:34 AM
// -------------------------------------------------------------------------------------

using System;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Data;

namespace AmiOperationLib
{
    public class ClientConnection
    {
        // Topic type: DCU/MeterType/MessageType/# (# for any DCU id)
        private string[] subscribeTopics;
        public delegate void ConnectStatusEventHandle(string serverName, string ipAddess, bool isConnected, string message);
        public event ConnectStatusEventHandle ConnectStatusEvent;
        public delegate void ReceiveMessageEventHandle(string topic, byte[] message);
        public event ReceiveMessageEventHandle receiveMessageEvent;
        public delegate void ReceiveMessageEventFlashFailHandle(string[] topic, byte[] message);
        public bool receive1Dcu = false;
        private byte[] qosLevel;
        private bool isConnected = false;
        private MqttClient mqttAmiHesClient;
        private int timeOut = 30;

        private AutoResetEvent timeOutEvent;
        private DataTable datatabletype = new DataTable();

        public bool IsClientClosedByUser
        {
            get;
            set;
        }

        public GatewayInfo GatewaysInfo { get; set; }

        /// <summary>
        /// Khởi tạo thông tin kết nối ban đầu
        /// </summary>
        private void InitConnection()
        {
            if (this.mqttAmiHesClient != null)
            {
                this.mqttAmiHesClient.MqttMsgPublishReceived -= client_MqttMsgPublishReceived;
                this.mqttAmiHesClient.ConnectionClosed -= client_ConnectionClosed;
            }
            this.mqttAmiHesClient = null;

            if (this.GatewaysInfo != null)
            {
                this.timeOut = this.GatewaysInfo.TimeOut * 1000;

                this.mqttAmiHesClient = new MqttClient(this.GatewaysInfo.BrokerAddress, this.GatewaysInfo.BrokerPort, false, null, null, MqttSslProtocols.None);
                // register event to message received 
                this.mqttAmiHesClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                this.mqttAmiHesClient.ConnectionClosed += client_ConnectionClosed;
            }
        }


        /// <summary>
        /// Disconnect to broker
        /// </summary>
        public void Disconnect()
        {
            this.IsClientClosedByUser = true;
            if (this.mqttAmiHesClient != null)
            {
                // If client is connected
                if (this.mqttAmiHesClient.IsConnected)
                {
                    try
                    {
                        // Send disconnect to gateway
                        this.mqttAmiHesClient.Disconnect();
                        if (ConnectStatusEvent != null)
                        {
                            ConnectStatusEvent(this.GatewaysInfo.ServerName, this.GatewaysInfo.BrokerAddress, false, "Client disconnected!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        if (this.ConnectStatusEvent != null)
                            ConnectStatusEvent(this.GatewaysInfo.ServerName, this.GatewaysInfo.BrokerAddress, true, "Cann't disconnect to gateway");
                    }
                }
            }

            MemoryManagement.MinimizeMemory();
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <returns></returns>
        public void ExistThreadDecode()
        {
            try
            {
                if (this.mqttAmiHesClient != null && this.mqttAmiHesClient.IsConnected)
                    this.mqttAmiHesClient.Disconnect();
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// Start mqtt client
        /// </summary>
        public void Connect()
        {
            try
            {
                if (this.mqttAmiHesClient == null)
                {
                    this.InitConnection();
                }
                else if (this.mqttAmiHesClient.IsConnected)
                {
                    this.UnSubscribeMessage();
                    this.Disconnect();

                    this.InitConnection();
                }

                // Connect to gateway
                this.mqttAmiHesClient.Connect(GatewaysInfo.ClientName, GatewaysInfo.UserName, GatewaysInfo.Password, true, 120);

                // Check connection before connect to server
                if (!this.mqttAmiHesClient.IsConnected)
                {
                    if (ConnectStatusEvent != null)
                        ConnectStatusEvent(this.GatewaysInfo.ServerName, this.GatewaysInfo.BrokerAddress, false, GatewaysInfo.ClientName + " is Connected!!!");
                    return;
                }

                this.IsClientClosedByUser = false;

                isConnected = true;
                if (ConnectStatusEvent != null)
                    ConnectStatusEvent(this.GatewaysInfo.ServerName, this.GatewaysInfo.BrokerAddress, true, string.Empty);
            }
            catch (Exception ex)
            {
                isConnected = false;

                if (ConnectStatusEvent != null)
                    ConnectStatusEvent(this.GatewaysInfo.ServerName, this.GatewaysInfo.BrokerAddress, false, GatewaysInfo.ClientName + ": Can't connect to gateway");
            }

            MemoryManagement.MinimizeMemory();
        }

        /// <summary>
        /// Đăng ký bản tin với gateways
        /// </summary>
        /// <param name="topicsString">Các bản tin cách nhau bởi dấu chấm phẩy ';'</param>
        public void SubscribeMessage(string topicsString)
        {
            if (this.mqttAmiHesClient != null && this.mqttAmiHesClient.IsConnected)
            {
                try
                {
                    this.subscribeTopics = FileUtil.GetSubscribeMessage(topicsString);
                    this.qosLevel = new byte[this.subscribeTopics.Length];

                    // Create qos for each message type
                    for (int i = 0; i < this.subscribeTopics.Length; i++)
                    {
                        this.qosLevel[i] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                    }

                    // Subscriber message to broker
                    this.mqttAmiHesClient.Subscribe(this.subscribeTopics, this.qosLevel);

                    // Save log topic
                    string topic = "Topics:";
                    for (int i = 0; i < subscribeTopics.Length; i++)
                    {
                        topic += subscribeTopics[i] + ";";
                    }
                }
                catch
                {

                }
            }
        }

        public void UnSubscribeMessage(string[] subscribe)
        {
            if (subscribe != null)
                this.mqttAmiHesClient.Unsubscribe(subscribe);
        }

        /// <summary>
        /// UnSubscribe các bản tin đã đăng ký trước đó
        /// </summary>
        public void UnSubscribeMessage()
        {
            if (this.mqttAmiHesClient != null && this.mqttAmiHesClient.IsConnected)
                this.mqttAmiHesClient.Unsubscribe(subscribeTopics);
        }


        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            this.receiveMessageEvent(e.Topic, e.Message);
        }

        private void client_ConnectionClosed(object sender, EventArgs e)
        {
            isConnected = false;

            // If client was closed by user 
            if (this.IsClientClosedByUser)
            {
                return;
            }

            this.timeOutEvent = new AutoResetEvent(false);

            if (ConnectStatusEvent != null)
            {
                ConnectStatusEvent(this.GatewaysInfo.ServerName, this.GatewaysInfo.BrokerAddress, false, "Auto reconnecting...");
            }

            while (!this.isConnected)
            {
                if (this.timeOutEvent == null)
                    break;
                this.timeOutEvent.WaitOne(timeOut);
                Connect();
            }
            if (this.timeOutEvent != null)
                this.timeOutEvent.Dispose();
            this.timeOutEvent = null;
        }

        public void PublishMessage(string topic, byte[] message)
        {
            if (this.mqttAmiHesClient != null)
                this.mqttAmiHesClient.Publish(topic, message);
        }
    }
}
