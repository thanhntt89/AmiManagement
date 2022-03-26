using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using System;
using System.IO;
using System.Linq;

namespace AmiOperationManagement.Ftp
{
    public class UploadFile
    {
        private ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
        private ServerTableAdapter serverTableAdapter = new ServerTableAdapter();

        public void DeleteFirmawre(string filePath)
        {
            this.serverTableAdapter.FillByTypeAndStatus(this.serverDataTable, Constant.SERVER_TYPE_FTP, true);

            string serverIp = this.serverDataTable.First().ServerIP;
            string userName = this.serverDataTable.First().UserName;
            string passWord = this.serverDataTable.First().Password;
            FtpClient.Delete(serverIp, userName, passWord, filePath);
        }

        public string UploadFirmware(string filePath)
        {
            string filePathInserver = string.Empty;

            this.serverTableAdapter.FillByTypeAndStatus(this.serverDataTable, Constant.SERVER_TYPE_FTP, true);

            string serverIp = this.serverDataTable.First().ServerIP;
            string userName = this.serverDataTable.First().UserName;
            string passWord = this.serverDataTable.First().Password;
            string fileName = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + Path.GetFileName(filePath);

            FtpClient.UploadFile(serverIp, userName, passWord, Constant.SERVER_FOLDER_PATH, fileName, filePath);
            filePathInserver = Path.Combine(Constant.SERVER_FOLDER_PATH, fileName);

            return filePathInserver;
        }
    }
}
