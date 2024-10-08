﻿using NFramework.Core.Interfaces;

namespace NFramework.Modules.Setup
{
    public class Module_Setup: IModule
    {
        public string ModuleName { get; set; }
        public string Version { get; set; }
        public int Order { get; set; }
        public Module_Setup() {
            ModuleName = "Module_Setup";
            Version = "1.0.0";
            Order = 0;
        }
    }
}
