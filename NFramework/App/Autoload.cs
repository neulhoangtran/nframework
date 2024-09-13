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
                Application.Run(new Start()); 
            }
        }
    }
}
