using log4net;
using log4net.Config;
using System;
using System.IO;

namespace AmiOperationLib
{
    public enum LogLevelL4N
    {
        DEBUG = 1,
        ERROR,
        FATAL,
        INFO,
        WARN
    }

    public static class Logger
    {
        #region Members
        private static readonly ILog logger = LogManager.GetLogger(typeof(Logger));
        #endregion

        #region Constructors
        static Logger()
        {
            FileInfo file = new FileInfo("Logs\\SystemLog.txt");
            if (!file.Exists)
                file.Create();

            XmlConfigurator.Configure(file);
        }
        #endregion

        #region Methods

        public static void WriteLog(LogLevelL4N logLevel, String log, Exception e = null)
        {
            if (logLevel.Equals(LogLevelL4N.DEBUG))
            {
                logger.Debug(log);
                if (e != null)
                {
                    logger.Debug(e);
                }
            }

            else if (logLevel.Equals(LogLevelL4N.ERROR))
            {
                logger.Error(log);
                if (e != null)
                {
                    logger.Error(e);
                }

            }

            else if (logLevel.Equals(LogLevelL4N.FATAL))
            {
                logger.Fatal(log);
                if (e != null)
                {
                    logger.Fatal(e);
                }

            }

            else if (logLevel.Equals(LogLevelL4N.INFO))
            {
                logger.Info(log);
                if (e != null)
                {
                    logger.Info(e);
                }


            }

            else if (logLevel.Equals(LogLevelL4N.WARN))
            {
                logger.Warn(log);
                if (e != null)
                {
                    logger.Warn(e);
                }
            }
        }

        #endregion

    }
}
