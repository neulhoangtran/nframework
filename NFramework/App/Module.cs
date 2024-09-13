using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NFramework.Core.Interfaces;
namespace NFramework.App
{
    public class ModuleEntity: IModule
    {
        public string ModuleName { get; set; }
        public string Version { get; set; }
        public int Order {  get; set; } = 0;
        public bool Status { get; set; } = false;
    }

    public class Module
    {
        List<ModuleEntity> _modules = new List<ModuleEntity>();
        public Module()
        {
            //GetModules();
        }

        public List<ModuleEntity> GetModules()
        {
            string FileModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "module.json");
            //string FileModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "module.json");
            //MessageBox.Show(Directory.GetDirectoryRoot("C:\test"));
            
            return _modules;
        }

        public void CreateAndLoadInitialModules()
        {
            string FileModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "module.json");
            if (File.Exists(FileModulePath))
            {
                MessageBox.Show(FileModulePath);
            }
            else
            {
                MessageBox.Show("success");
            }

        }
    }

    public static class Modules
    {
        public static List<IModule> GetModules() {
            List<IModule> _modules = new List<IModule>();
            string modulesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules");
            var moduleFiles = Directory.GetFiles(modulesPath, "*.cs", SearchOption.AllDirectories);
            //var test = File.Exists() ? "a" : "b";
            //MessageBox.Show(test);
            //return 
            return _modules;
        }
    }

}
