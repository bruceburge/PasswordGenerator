using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class VerbVerbAndVerb : IPasswordPattern
    {
        private Random rnd;

        public void Initialize(Random random)
        {
            rnd = random;
        }

        public string GetPattern()
        {

            return string.Format("{0}.{1}.and.{2}",
                WordLibs.UppercaseWords(WordLibs.Verbs[rnd.Next(WordLibs.Verbs.Length)]),
                WordLibs.UppercaseWords(WordLibs.Verbs[rnd.Next(WordLibs.Verbs.Length)]),
                WordLibs.UppercaseWords(WordLibs.Verbs[rnd.Next(WordLibs.Verbs.Length)]));

        }

        public string GetPatternTitle()
        {
            return "Verb.Verb.And.Verb";
        }
    }
}
