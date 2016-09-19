using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*using Mecof.Infrastructure;
using Mecof.Infrastructure.Logging.Loggers;
using Mecof.Infrastructure.Logging.Managers;
using Mecof.Infrastructure.Configuration;
using System.IO;
using System.Reflection;*/

namespace Examenes
{
    static class Program
    {
        /*private static ILogger logger;


        /// <summary>
        /// Initilizes the logger
        /// If logger initialization fails exception is thrown
        /// </summary>
        private static void InitializeLoggingSystem()
        {
            var appFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string configStream = File.ReadAllText(Path.Combine(appFolder, "log4NetConfig.xml"));
            ILogManager logManager = new Log4NetLogManager(configStream);
            ServiceLocator.Instance.RegisterObject<ILogManager>(logManager);
            logger = logManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //ServiceLocator.Instance.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        }*/




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //InitializeLoggingSystem();
            //logger.Info("Application Started");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_Vista());
        }
    }
}
