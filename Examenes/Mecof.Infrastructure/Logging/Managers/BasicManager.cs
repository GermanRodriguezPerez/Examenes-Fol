using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;

using Mecof.Infrastructure.Logging.Loggers;

namespace Mecof.Infrastructure.Logging.Managers
{
    public class BasicManager : ILogManager
    {
        private ILogger logger;

        public BasicManager(ILogger logger)
        {
            this.logger = logger;
        }

        public ILogger GetLogger(string name)
        {
            return this.logger;
        }

        public ILogger GetLogger(Type type)
        {
            return this.logger;
        }
    }
}
