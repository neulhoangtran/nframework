using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFramework.Core.Interfaces
{
    public interface ILanguageProvider
    {
        //public void load
        string LanguageCode { set; get; }
        string LanguageName { set; get; }
        void Register(); // Register language
    }
}
