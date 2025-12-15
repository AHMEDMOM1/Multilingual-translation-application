using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilingual_translation_application.Services.Translation
{
    internal interface ITranslationService
    {
        string Translate(string input, string fromLang, string toang);
    }
}
