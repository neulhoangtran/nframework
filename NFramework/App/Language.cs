using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFramework.Core.Interfaces;

namespace NFramework.App
{
    public class Language
    {
        private readonly List<ILanguageProvider> _languages = new List<ILanguageProvider>();

        public void RegisterLanguage(ILanguageProvider language)
        {
            // Check if language not in the list of languages
            if (!_languages.Contains(language))
            {
                _languages.Add(language);
                language.Register();
            }
        }

        public List<ILanguageProvider> LoadLanguagesFromModules()
        {
            return _languages.Distinct().ToList();
        }
    }

}
