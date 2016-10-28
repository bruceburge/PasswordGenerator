using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class NounVerbNoun : IPasswordPattern
    {
        private Random rnd;

        public void Initialize(Random random)
        {
            rnd = random;
        }

        public string GetPattern()
        {
            return string.Format("{0}.{1}.{2}",
                WordLibs.UppercaseWords(WordLibs.Nouns[rnd.Next(WordLibs.Nouns.Length)]), 
                WordLibs.Verbs[rnd.Next(WordLibs.Verbs.Length)], 
                WordLibs.Nouns[rnd.Next(WordLibs.Nouns.Length)]);
        }

        public string GetPatternTitle()
        {
            return "Noun.Verb.Noun";
        }
    }
}
