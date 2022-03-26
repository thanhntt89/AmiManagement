//-----< Class Name="FileUtil.cs" copyrigth (C) SAO VIET GROUP >-------
// Author: Nguyen Tat Thanh
// Email: thanhnt@saovietgroup.com.vn
// Mobile: 098 664 8910
// Created date: Monday, June 15, 2015 9:50 AM
// -------------------------------------------------------------------------------------

using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System;
using System.Collections.Generic;
using AmiOperationLib;
namespace AmiOperationLib
{
    public static class FileUtil
    {

        static public byte[] RemovedCheckSum(byte[] _packetData)
        {
            if (_packetData.Length < 2)
                return null;

            byte[] temp = new byte[_packetData.Length - 1];

            if (!ValidateByte(_packetData))
            {
                return null;
            }
            try
            {
                Array.Copy(_packetData, temp, _packetData.Length - 1);
            }
            catch
            {
                return null;
            }
            return temp;
        }

        static public bool ValidateByte(byte[] packetData)
        {
            bool isResult = false;
            Byte _checkSumByte = 0x00;

            if (packetData.Length < 2)
                return false;

            byte last_byte = packetData[packetData.Length - 1];

            for (int i = 0; i < packetData.Length - 1; i++)
                _checkSumByte += packetData[i];

            if (last_byte == _checkSumByte)
                isResult = true;

            return isResult;
        }

        public static string[] GetSubscribeMessage(string topicArray)
        {
            return topicArray.Split(';');
        }

        public static string GetDataFolder()
        {
            XDocument reader = XDocument.Load(Constant.SystemConfig);

            var getInfo = from row in reader.Descendants("dataFolder")
                          select row;

            if (getInfo.Count() == 0)
            {
                return null;
            }

            return getInfo.First().Attribute("folderName").Value;
        }

        public static string GetSqlConnectionString(string tag, string atribute)
        {
            try
            {
                XDocument reader = XDocument.Load(Constant.SystemConfig);

                var getInfo = from row in reader.Descendants(tag)
                              select row;
                if (getInfo.Count() == 0)
                {
                    return null;
                }
                return getInfo.First().Attribute(atribute).Value;
            }
            catch
            {
                return null;
            }
        }

        public static bool SaveSystemConfig(string tag, string atribute, string value)
        {

            try
            {
                XDocument reader = XDocument.Load(Constant.SystemConfig);

                var getInfo = from row in reader.Descendants(tag)
                              select row;
                if (getInfo.Count() == 0)
                {
                    return false;
                }
                getInfo.First().Attribute(atribute).Value = value;
                reader.Save(Constant.SystemConfig);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Read gateway config
        /// </summary>
        /// <param name="fileConfigPath">fileConfigPath</param>
        /// <returns></returns>
        public static GatewayInfo GetGatewayInfo()
        {
            GatewayInfo serverInfo = new GatewayInfo();
            // Load file server config 
            if (!File.Exists(Constant.SystemConfig))
            {
                return null;
            }

            XDocument reader = XDocument.Load(Constant.SystemConfig);

            var getInfo = from row in reader.Descendants("gatewayInfo")
                          select row;

            if (getInfo.Count() == 0)
            {
                return null;
            }

            serverInfo.ClientName = getInfo.First().Attribute("clientName").Value;
            serverInfo.BrokerAddress = getInfo.First().Attribute("serverAddress").Value;
            serverInfo.BrokerPort = Int32.Parse(getInfo.First().Attribute("mqttPort").Value);
            serverInfo.OpenWritePort = Int32.Parse(getInfo.First().Attribute("openwritePort").Value);
            serverInfo.UserName = getInfo.First().Attribute("userName").Value;
            serverInfo.Password = getInfo.First().Attribute("password").Value;
            serverInfo.Topics = getInfo.First().Attribute("topicName").Value;
            serverInfo.TimeOut = Int32.Parse(getInfo.First().Attribute("timeOut").Value);
            serverInfo.QoS = Int32.Parse(getInfo.First().Attribute("qoS").Value);
            //serverInfo.AmiType = Int32.Parse(getInfo.First().Attribute("type").Value);
            return serverInfo;
        }

        public static bool GetStatusToolConfig(string tagId)
        {
            // Load file server config 
            if (!File.Exists(Constant.SystemConfig))
            {
                return false;
            }

            XDocument reader = XDocument.Load(Constant.SystemConfig);

            var getInfo = from row in reader.Descendants("toolConfig")
                          select row;

            if (getInfo.Count() == 0)
            {
                return false;
            }

            return bool.Parse(getInfo.First().Attribute(tagId).Value);
        }

        public static void CreateServerConfigDefault()
        {
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            string currentIp = string.Empty;
            foreach (var item in ip)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    currentIp = item.ToString();
                    break;
                }
            }

            if (!File.Exists(Constant.ServerConfigFile))
            {
                FileUtil.CreateServerFileConfigs(Constant.ServerConfigFile, currentIp, 2020, 3000, 1024, 100, 5, 5);
            }
        }

        public static void CreateServerFileConfigs(string filePath, string iPAddress,
            int portName,
            int maxNumberOfConnections,
            int bufferSize,
            int backLog,
            int maxTrySendingNumber,
            int watingTime)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement rootElement = xmlDoc.CreateElement("ServerConfig");
            xmlDoc.InsertBefore(xmlDec, xmlDoc.DocumentElement);
            xmlDoc.AppendChild(rootElement);
            XmlElement serverInfoElement = xmlDoc.CreateElement("ServerInfo");
            serverInfoElement.SetAttribute("IPAddress", iPAddress);
            serverInfoElement.SetAttribute("Port", portName.ToString());
            serverInfoElement.SetAttribute("MaxNumberOfConnections", maxNumberOfConnections.ToString());
            serverInfoElement.SetAttribute("BufferSize", bufferSize.ToString());
            serverInfoElement.SetAttribute("Backlog", backLog.ToString());
            serverInfoElement.SetAttribute("MaxTrySendingNumber", maxTrySendingNumber.ToString());
            serverInfoElement.SetAttribute("WaitingTime", watingTime.ToString());
            rootElement.AppendChild(serverInfoElement);

            xmlDoc.Save(filePath);
        }

        /// <summary>
        /// Read update file
        /// </summary>
        /// <param name="hexfilePath"></param>
        /// <returns></returns>
        public static string ReadHexFileToString(string hexfilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = System.IO.File.ReadAllLines(hexfilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string data = lines[i].Substring(9, lines[i].Length - 11);
                if (data.Length == 32)
                {
                    string group1 = ChangeBytePostion(data.Substring(0, 8));
                    string group2 = ChangeBytePostion(data.Substring(8, 8));
                    string group3 = ChangeBytePostion(data.Substring(16, 8));
                    string group4 = ChangeBytePostion(data.Substring(24, 8));
                    data = group1 + group2 + group3 + group4;
                    sb.Append(data);
                }
            }

            string exData = lines[lines.Length - 3].Substring(9, lines[lines.Length - 3].Length - 11);
            // Xử lý ngoại lệ trường hợp dòng cuối cùng vị trí thứ 3 từ dưới lên không đủ 32 ký tự dữ liệu 
            if (exData.Length < 32)
            {
                string exGroup1 = string.Empty;
                string exGroup2 = string.Empty;
                string exGroup3 = string.Empty;

                // Trường hợp có 1 nhóm
                if (exData.Length == 8)
                {
                    exGroup1 = ChangeBytePostion(exData.Substring(0, 8));
                }
                // Trường hợp có 2 nhóm
                else if (exData.Length == 16)
                {
                    exGroup1 = ChangeBytePostion(exData.Substring(0, 8));
                    exGroup2 = ChangeBytePostion(exData.Substring(8, 8));
                }
                // Trường hợp có 3 nhóm
                else if (exData.Length == 24)
                {
                    exGroup1 = ChangeBytePostion(exData.Substring(0, 8));
                    exGroup2 = ChangeBytePostion(exData.Substring(8, 8));
                    exGroup3 = ChangeBytePostion(exData.Substring(16, 8));
                }
                exData = exGroup1 + exGroup2 + exGroup3;
                sb.Append(exData);
            }

            return sb.ToString();
        }

        private static string ChangeBytePostion(string byteString)
        {
            string newString = string.Empty;
            int maxSize = byteString.Length / 2;
            string[] temp = new string[maxSize];
            int index = 0;
            int increse = 0;
            while (maxSize > index)
            {
                temp[index] = byteString.Substring(increse, 2);
                increse += 2;
                index++;
            }

            index = temp.Length;
            while (index > 0)
            {
                newString += temp[(index - 1)];
                index--;
            }

            return newString;
        }

        /// <summary>
        /// Save file to file 
        /// </summary>
        /// <param name="filePath">filePath</param>
        /// <param name="listContent">listContent</param>
        /// <remarks>Return exception</remarks>
        public static void SaveFile(string filePath, List<string> listContent)
        {
            TextWriter sw = new StreamWriter(filePath);
            try
            {
                foreach (var item in listContent)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    //<Summary>
    // This class used to created log files
    // Created by ali ahmad h - 2002
    //</Summary>
    public class CreateLogFiles
    {
        private static string sLogFormat;
        private static string sErrorTime;
        private static string filePath;

        static CreateLogFiles()
        {
            //sLogFormat used to create log files format :
            // dd/mm/yyyy hh:mm:ss AM/PM ==> Log Message


            //this variable used to create log filename format "
            //for example filename : ErrorLogYYYYMMDD
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            sErrorTime = sYear + sMonth + sDay;
            filePath = "Logs/Log_" + sErrorTime;
            DirectoryInfo dr = new DirectoryInfo("Logs");
            if (!dr.Exists)
            {
                dr.Create();
            }
        }

        public static void ErrorLog(string sErrMsg)
        {
            sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + ": ";
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(sLogFormat + sErrMsg);
            sw.Flush();
            sw.Close();
        }
    }

    public class SavePacket
    {
        private static string filePath = FileUtil.GetDataFolder();

        static SavePacket()
        {
            DirectoryInfo dr = new DirectoryInfo(filePath);
            if (!dr.Exists)
            {
                dr.Create();
            }
        }

        public static void CreateMessage(string prefixed, string dcuCode, string content)
        {
            StreamWriter sw = new StreamWriter(filePath + "\\" + dcuCode + "_" + CreateAutoId(prefixed), true);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// Creat auto table id
        /// </summary>
        /// <returns></returns>
        private static string CreateAutoId(string prefiex)
        {
            string id = string.Empty;
            int yyyy = DateTime.Now.Year;
            int dd = DateTime.Now.Day;
            int mm = DateTime.Now.Month;
            int hh = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            int mcs = DateTime.Now.Millisecond + 1;
            id = yyyy.ToString() + dd.ToString().PadLeft(2, '0') + mm.ToString().PadLeft(2, '0') + hh.ToString().PadLeft(2, '0') + min.ToString().PadLeft(2, '0') + ss.ToString().PadLeft(2, '0') + mcs.ToString().PadLeft(2, '0');

            id = prefiex + id.PadLeft(20 - prefiex.Length, '0');

            return id;
        }
    }
}
