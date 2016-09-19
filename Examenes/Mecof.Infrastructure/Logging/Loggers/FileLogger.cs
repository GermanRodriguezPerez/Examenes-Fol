using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mecof.Infrastructure.Logging.Loggers
{
    public class FileLogger: ILogger
    {
        private string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void Debug(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(message);
                sw.Flush();
            }
        }

        public void Info(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(message);
                sw.Flush();
            }
        }

        public void Warn(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(message);
                sw.Flush();
            }
        }

        public void Error(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(message);
                sw.Flush();
            }
        }

        public void Fatal(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(message);
                sw.Flush();
            }
        }
    }
}