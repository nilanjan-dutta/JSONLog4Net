using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace JSONLOgging
{
    internal class LoggingExample
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoggingExample));

        public LoggingExample()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("App1.config"));

            log.Debug("Instantiating Logging Example"+ Environment.NewLine + "Another Line of info");
        }

        public void LogError()
        {
            log.Error("Error Occurred");
        }

    }
}
