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
            Application.Run(new Start());
            Applicaction app = new Applicaction();
            Module mdl = new Module();
        }

        public void Run()
        {

        }


    }
}
