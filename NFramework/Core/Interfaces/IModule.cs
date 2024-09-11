using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFramework.Core.Interfaces
{
    public interface IModule
    {
        string ModuleName { get; set; }
        string Version { get; set; }
        int Order { get; set; }

    }
}
