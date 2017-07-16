using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Falcon.Core.Server
{
    public interface IPluginModule : ServiceControl
    {
      void Configure();
    }
}
