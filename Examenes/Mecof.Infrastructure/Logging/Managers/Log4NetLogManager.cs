using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using log4net;

using Mecof.Infrastructure.Logging.Loggers;

namespace Mecof.Infrastructure.Logging.Managers
{
    public class Log4NetLogManager: ILogManager
    {
        // (@aartimeperez) 
        // For log patterns take a look at http://logging.apache.org/log4net/release/sdk/log4net.Layout.PatternLayout.html        
        public Log4NetLogManager(System.IO.FileInfo file)
        {            
            log4net.Config.XmlConfigurator.ConfigureAndWatch(file);
        }

        public Log4NetLogManager(string configStream)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(configStream);
            MemoryStream stream = new MemoryStream(byteArray);
            log4net.Config.XmlConfigurator.Configure(stream);
        }


        public ILogger GetLogger(string name)
        {
            return new Log4NetLogger(LogManager.GetLogger(name));
        }

        public ILogger GetLogger(Type type)
        {
            return new Log4NetLogger(LogManager.GetLogger(type));
        }
    }
}
