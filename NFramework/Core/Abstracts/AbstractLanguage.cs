using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFramework.Core.Interfaces;

namespace NFramework.Core.Abstracts
{
    public abstract class AbstractLanguage: ILanguageProvider
    {
        public abstract string LanguageCode { set; get; }
        public abstract string LanguageName { set; get; }

        public virtual void Register()
        {

        }
    }
}
