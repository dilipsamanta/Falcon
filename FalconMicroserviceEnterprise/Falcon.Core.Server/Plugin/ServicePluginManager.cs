using Falcon.Server.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Registration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Core.Server
{
    public class ServicePluginManager : PluginManager
    {
        public override void Build()
        {
          var convention = new RegistrationBuilder();

        }
    }
}
