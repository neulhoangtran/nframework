using NFramework.Core.Interfaces;

namespace NFramework.Modules.Language
{
    internal class Module_Language: IModule
    {
        public string ModuleName { get; set; }
        public string Version { get; set; }
        public int Order { get; set; }
        public Module_Language()
        {
            ModuleName = "Module_Language";
            Version = "1.0.0";
            Order = 0;
        }
    }
}
