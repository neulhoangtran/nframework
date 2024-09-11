using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFramework.Core.Utilities
{
    public static class Logger
    {
        private static readonly string LogDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Log");
        private static readonly string DebugLogPath = Path.Combine(LogDirectory, "debug.log");
        private static readonly string SystemLogPath = Path.Combine(LogDirectory, "system.log");

        static Logger()
        {
            //if
        }
    }
}
