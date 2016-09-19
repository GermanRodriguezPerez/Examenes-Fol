using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mecof.Infrastructure.Logging.Loggers;

namespace Mecof.Infrastructure.Logging.Managers
{
    public interface ILogManager
    {
        ILogger GetLogger(string name);
        ILogger GetLogger(Type type);

    }
}
