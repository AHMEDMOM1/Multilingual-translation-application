using Multilingual_translation_application.Models;
using Multilingual_translation_application.Services.Translation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1.Services.Translation
{
    public class TranslationService : ITranslationService
    {
        private readonly List<WordPair> _dictionary;

        public TranslationService()
        {
            _dictionary = new List<WordPair>
            {
                new WordPair { English = "hello", Turkish = "merhaba", Arabic = "مرحبا" },
                new WordPair { English = "cat",   Turkish = "kedi",    Arabic = "قط" },
                new WordPair { English = "good",  Turkish = "iyi",     Arabic = "جيد" },
                new WordPair { English = "world", Turkish = "dünya",   Arabic = "العالم" },
                
            };
        }

        public string Translate(string input, string fromLang, string toLang)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            
            if (string.Equals(fromLang, toLang, StringComparison.OrdinalIgnoreCase))
                return input;

            
            var words = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var resultWords = new List<string>();

            foreach (var w in words)
            {
                var word = w.Trim();

                
                WordPair pair = _dictionary.FirstOrDefault(p =>
                    (fromLang == "English" && string.Equals(p.English, word, StringComparison.OrdinalIgnoreCase)) ||
                    (fromLang == "Turkish" && string.Equals(p.Turkish, word, StringComparison.OrdinalIgnoreCase)) ||
                    (fromLang == "Arabic" && string.Equals(p.Arabic, word, StringComparison.OrdinalIgnoreCase))
                );

                if (pair == null)
                {
                    
                    resultWords.Add(word);
                    continue;
                }

                
                string translated;

                switch (toLang)
                {
                    case "English":
                        translated = pair.English;
                        break;

                    case "Turkish":
                        translated = pair.Turkish;
                        break;

                    case "Arabic":
                        translated = pair.Arabic;
                        break;

                    default:
                        translated = word;   
                        break;
                }


                resultWords.Add(translated);
            }

            
            return string.Join(" ", resultWords);
        }
    }
}
