using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFramework.Core.Interfaces;

namespace NFramework.Modules.User
{
    public class Module_User : IModule
    {
        public string ModuleName { get; set; }
        public string Version { get; set; }
        public int Order { get; set; }
        public Module_User()
        {
            ModuleName = "Module_User";
            Version = "1.0.0";
            Order = 0;
        }
    }
}
