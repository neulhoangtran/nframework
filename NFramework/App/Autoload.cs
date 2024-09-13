using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFramework.App.Init;

namespace NFramework.App
{
    public class Autoload
    {
        public Autoload() {
            InitialCheckAndLoad();
        }

        public void Run()
        {
            

        }

        private void InitialCheckAndLoad() {
            string FileModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "module.json");
            string FileConfigurationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Config", "application.json");
            if (File.Exists(FileModulePath) && File.Exists(FileConfigurationPath))
            {
                Module mdl = new Module();
                Applicaction app = new Applicaction();
                MessageBox.Show("test");
            }
            else {
                string modulesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules");
                //var moduleFiles = Directory.GetFiles(modulesPath, "*.cs", SearchOption.AllDirectories);
                var test = Directory.Exists(modulesPath) == false ? "a" : "b";
                MessageBox.Show(test);
                //MessageBox.Show(test);
                //Modules.GetModules();
                Application.Run(new Start()); 
            }
        }
    }
}
