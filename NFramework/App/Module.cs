using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace NFramework.App
{
    public class ModuleEntity
    {
        public string ModuleName { get; set; }
        public bool Status { get; set; }
    }

    public class Module
    {
        public List<ModuleEntity> GetModules()
        {
            List<ModuleEntity> moduleEntities = new List<ModuleEntity>();
            //string FileModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "module.json");
            string FileModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "module.json");
            MessageBox.Show(Directory.GetDirectoryRoot("C:\test"));
            if (File.Exists(FileModulePath))
            {
                MessageBox.Show("aaaaa");

            } else
            {
                MessageBox.Show("bbbbb");
            }
            return moduleEntities;
        }
    }

}
