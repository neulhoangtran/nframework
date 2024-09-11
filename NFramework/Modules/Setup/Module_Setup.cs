using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFramework.Core.Interfaces;

namespace NFramework.Modules.Setup
{
    public class Module_Setup: IModule
    {
        public string ModuleName { get; set; }
        public string Version { get; set; }
        public int Order { get; set; }
        public Module_Setup() {
            ModuleName = "Setup";
            Version = "1.0.0";
            Order = 0;
        }
    }
}
