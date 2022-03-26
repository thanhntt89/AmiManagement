using AmiOperationLib;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AmiOperationManagement.Systems
{
    public class DataBaseConnection
    {
        private string sqlFormartString = "Data Source={0};Initial Catalog={1};Persist Security Info={2};User ID={3};Password={4}";
        private string amiSystemConnectionString = string.Empty;
        private string amiSystemOperationConnectionString = string.Empty;

        public DataBaseConnection()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                amiSystemConnectionString = Sercurity.Decrypt(FileUtil.GetSqlConnectionString("sqlconnectionStrings", Constant.CLIENT_CONNECTION));// config.ConnectionStrings.ConnectionStrings[Constant.CLIENT_CONNECTION].ConnectionString; ;//
                amiSystemOperationConnectionString = Sercurity.Decrypt(FileUtil.GetSqlConnectionString("sqlconnectionStrings", Constant.ADMIN_CONNECTION));//config.ConnectionStrings.ConnectionStrings[Constant.ADMIN_CONNECTION].ConnectionString;//

                // Set AmiSystemConnectionString
                OperationDTO.Properties.Settings.Default[Constant.CLIENT_CONNECTION] = amiSystemConnectionString;//config.ConnectionStrings.ConnectionStrings[Constant.CLIENT_CONNECTION].ConnectionString;//
                OperationDTO.Properties.Settings.Default[Constant.ADMIN_CONNECTION] = amiSystemOperationConnectionString;//config.ConnectionStrings.ConnectionStrings[Constant.ADMIN_CONNECTION].ConnectionString;//
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckSqlConnection()
        {
            SqlConnection connectionAmiSystem = null;
            SqlConnection connectionAmiReport = null;        

            bool isConnected = false;
            try
            {
                connectionAmiSystem = new SqlConnection(amiSystemConnectionString);//config.ConnectionStrings.ConnectionStrings[Constant.CLIENT_CONNECTION].ConnectionString);//
                connectionAmiSystem.Open();
                connectionAmiSystem.Close();
                isConnected = true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi không kết nối được cơ sở dữ liệu KHÁCH HÀNG - Chi tiết lỗi: ", ex);
                return false;
            }

            try
            {
                connectionAmiReport = new SqlConnection(amiSystemOperationConnectionString);//config.ConnectionStrings.ConnectionStrings[Constant.ADMIN_CONNECTION].ConnectionString);//
                connectionAmiReport.Open();
                connectionAmiReport.Close();
                isConnected = true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi không kết nối được cơ sở dữ liệu QUẢN LÝ - Chi tiết lỗi: ", ex);
                return false;
            }

            return isConnected;
        }

        private void SaveConnectionString(string connection, string connectionString)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings[connection].ConnectionString = Sercurity.Encrypt(connectionString);

            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection(connection);
            //Properties.Settings.Default.Reload();            
            FileUtil.SaveSystemConfig("sqlconnectionStrings", connection, Sercurity.Encrypt(connectionString));
        }

        public bool CheckConnection(string connection, string serverIp, string database, string userName, string password, bool security)
        {
            string connectionString = String.Format(sqlFormartString, serverIp, database, security, userName, password);
            SqlConnection connectionAmiSystem = new SqlConnection(connectionString);

            try
            {
                connectionAmiSystem.Open();
                connectionAmiSystem.Close();
                this.SaveConnectionString(connection, connectionString);
                return true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi không lưu được chuỗi két nối cơ sở dữ liệu - ConnectionString: " + connectionString + " Chi tiết lỗi: ", ex);
                return false;
            }

        }
    }
}
