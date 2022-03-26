using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ErrorManagement.Util
{

    public class SqlConnectionUtil
    {
        static SqlConnection sqlconnetion;
        static string SystemConfig = Application.StartupPath + "\\SystemConfig.xml";

        public static SqlConnection connection()
        {
            return sqlconnetion;
        }

        private static bool CheckConnection()
        {
            sqlconnetion = new SqlConnection(GetSqlConnectionString("sqlconnectionStrings"));
            try
            {
                sqlconnetion.Open();
                sqlconnetion.Close();
                return true;
            }
            catch { return false; }

        }

        public static string GetSqlConnectionString(string tag)
        {
            try
            {
                XDocument reader = XDocument.Load(SystemConfig);

                var getInfo = from row in reader.Descendants(tag)
                              select row;
                if (getInfo.Count() == 0)
                {
                    return null;
                }
                return getInfo.First().Attribute("connectionString").Value;
            }
            catch
            {
                return null;
            }
        }
    }
}
