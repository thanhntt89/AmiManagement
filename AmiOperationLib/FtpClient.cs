using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace AmiOperationLib
{
    public delegate void GeLengthFileDownloadHandle(int length);
    public delegate void SendPercentFileDownloadHandle(int length);

    public class FtpClient
    {
        public static event GeLengthFileDownloadHandle GeLengthFileDownloadEvent;
        public static event SendPercentFileDownloadHandle SendPercentFileDownloadEvent;

        public static void DownloadFile(string FTPAddress, string username, string password, string fileNameInServer, string filePathDestination)
        {
            FtpWebRequest reqFTP;
            try
            {
                FileStream outputStream = new FileStream(filePathDestination, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + FTPAddress + "/" + fileNameInServer));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(username, password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                int fileSize = (int)GetFileSize(FTPAddress, username, password, fileNameInServer);
                if (GeLengthFileDownloadEvent != null)
                    GeLengthFileDownloadEvent(fileSize);

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                int count = readCount;
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);

                    if (SendPercentFileDownloadEvent != null)
                        SendPercentFileDownloadEvent(count);

                    count += readCount;
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long GetFileSize(string FTPAddress, string username, string password, string fileNameInServer)
        {
            long size = -1;
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + FTPAddress + "/" + fileNameInServer));
                request.Proxy = null;
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                size = response.ContentLength;
                response.Close();
            }
            catch
            {
                throw;
            }
            return size;
        }

        public static void UploadFile(string FTPAddress, string username, string password, string folderInServer, string fileNameInServer, string fileUploadPath)
        {
            if (!File.Exists(fileUploadPath))
            {
                return;
            }

            // Check folder if exists
            CreateFolder(FTPAddress, folderInServer, username, password);

            // Removed data in folder
            // DeleteDirectory(FTPAddress, username, password, folderInServer);

            FileStream fileStream = File.OpenRead(fileUploadPath);

            int length = 1024;
            byte[] buffer = new byte[length];

            FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + FTPAddress + "/" + folderInServer + "/" + fileNameInServer);
            requestFTPUploader.Credentials = new NetworkCredential(username, password);
            requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

            Stream uploadStream = requestFTPUploader.GetRequestStream();
            int contentLength = buffer.Length;

            while (contentLength != 0)
            {
                contentLength = fileStream.Read(buffer, 0, contentLength);
                uploadStream.Write(buffer, 0, contentLength);
            }

            uploadStream.Close();
            requestFTPUploader = null;

        }

        public static void UploadPacketFile(string FTPAddress, string username, string password, string folderInServer, string fileUploadPath)
        {
            // Packet list to send
            List<string> packetList = new List<string>();

            UploadFile(FTPAddress, username, password, folderInServer, Path.GetFileName(fileUploadPath), fileUploadPath);

        }

        /// <summary>
        /// Upload file to FTP server
        /// </summary>
        /// <param name="dataUpload">dataUpload</param>
        /// <param name="folderNameInServer">folderName</param>
        /// <param name="fileNameInServer">fileName</param>
        /// <param name="FTPAddress">FTPAddress</param>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        private static void UploadFile(byte[] dataUpload, string folderNameInServer, string fileNameInServer, string FTPAddress, string username, string password)
        {
            FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + FTPAddress + "/" + folderNameInServer + "/" + fileNameInServer);
            requestFTPUploader.Credentials = new NetworkCredential(username, password);
            requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

            //int bufferLength = 1000;
            // byte[] buffer = new byte[bufferLength];

            Stream uploadStream = requestFTPUploader.GetRequestStream();
            int contentLength = dataUpload.Length;

            //while (contentLength != 0)
            //{
            uploadStream.Write(dataUpload, 0, contentLength);
            //    }

            uploadStream.Close();
            requestFTPUploader = null;
        }

        /// <summary>
        /// Check directory exists
        /// </summary>
        /// <param name="FTPAddress">FTPAddress</param>
        /// <param name="folderName">folderName</param>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        private static bool DirectoryExists(string FTPAddress, string folderName, string username, string password)
        {
            /* Create an FTP Request */
            FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + FTPAddress + "/" + folderName);
            /* Log in to the FTP Server with the User Name and Password Provided */
            ftpRequest.Credentials = new NetworkCredential(username, password);
            /* Specify the Type of FTP Request */
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

                    /* Resource Cleanup */
            finally
            {
                ftpRequest = null;
            }
        }

        /// <summary>
        /// Check directory exists
        /// </summary>
        /// <param name="FTPAddress">FTPAddress</param>
        /// <param name="folderName">folderName</param>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        private static void CreateFolder(string FTPAddress, string folderName, string username, string password)
        {
            if (DirectoryExists(FTPAddress, folderName, username, password))
            {

                return;
            }

            //Create FTP request
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://" + FTPAddress + "/" + folderName);
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            using (var resp = (FtpWebResponse)request.GetResponse())
            {
            }
        }

        public static void Delete(string ftpserverAddress, string username, string password, string fileDeletePath)
        {
            try
            {
                /* Create an FTP Request */
                var ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ftpserverAddress + "/" + fileDeletePath);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(username, password);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                /* Establish Return Communication with the FTP Server */
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Resource Cleanup */
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch
            {
                //Console.WriteLine(ex.ToString()); 
                try
                {
                    DeleteDirectory(ftpserverAddress, username, password, fileDeletePath);
                }
                catch { }
            }
            return;
        }

        public static void DeleteDirectory(string ftpserverAddress, string username, string password, string directoryName)
        {
            try
            {
                //Check files inside 
                var direcotryChildren = DirectoryListSimple(ftpserverAddress, username, password, directoryName);
                if (direcotryChildren.Any() && (!string.IsNullOrWhiteSpace(direcotryChildren[0])))
                {
                    foreach (var child in direcotryChildren)
                    {
                        Delete(ftpserverAddress, username, password, directoryName + "/" + child);
                    }
                }

                /* Create an FTP Request */
                var ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ftpserverAddress + "/" + directoryName);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(username, password);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;

                /* Establish Return Communication with the FTP Server */
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Resource Cleanup */
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        private static string[] DirectoryListSimple(string ftpserverAddress, string username, string password, string directory)
        {
            try
            {
                /* Create an FTP Request */
                var ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ftpserverAddress + "/" + directory);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(username, password);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                /* Establish Return Communication with the FTP Server */
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Establish Return Communication with the FTP Server */
                var ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try { while (ftpReader.Peek() != -1) { directoryRaw += ftpReader.ReadLine() + "|"; } }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try { string[] directoryList = directoryRaw.Split("|".ToCharArray()); return directoryList; }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            /* Return an Empty string Array if an Exception Occurs */
            return new string[] { "" };
        }

        /* List Directory Contents in Detail (Name, Size, Created, etc.) */
        private static string[] DirectoryListDetailed(string ftpserverAddress, string username, string password, string directory)
        {
            try
            {
                /* Create an FTP Request */
                var ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ftpserverAddress + "/" + directory);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(username, password);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                /* Establish Return Communication with the FTP Server */
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Establish Return Communication with the FTP Server */
                var ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try { while (ftpReader.Peek() != -1) { directoryRaw += ftpReader.ReadLine() + "|"; } }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try { string[] directoryList = directoryRaw.Split("|".ToCharArray()); return directoryList; }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            /* Return an Empty string Array if an Exception Occurs */
            return new string[] { "" };
        }
    }
}
