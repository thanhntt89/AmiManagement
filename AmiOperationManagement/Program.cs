using AmiOperationLib;
using AmiOperationManagement.Main;
using AmiOperationManagement.Systems;
using log4net.Config;
using System;
using System.Windows.Forms;

namespace AmiOperationManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataBaseConnection dbConnection = null;

            try
            {
                XmlConfigurator.Configure();
                dbConnection = new DataBaseConnection();
                Logger.WriteLog(LogLevelL4N.INFO, "Start-CreateNewLog");
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi không kết nối được cơ sở dữ liệu. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi không kết nối được cơ sở dữ liệu - Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbConnection.CheckSqlConnection())
            {
                StartupSystem startupSystem = new StartupSystem();
                Application.Run(startupSystem);

                if (startupSystem.isLoadSusess)
                {
                    LoginSystem login = new LoginSystem();
                    Application.Run(login);
                    if (login.isLogined)
                        Application.Run(new OperationMain());
                }
            }
            else
            {
                MessageBox.Show("Không kết nối được đến cơ sở dữ liệu. Bạn hãy kiểm tra lại thông tin kết nối đến các cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Run(new DatabaseConfig());
            }
        }
    }
}
