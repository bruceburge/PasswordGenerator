using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class VerbVerbAndVerb : IPasswordPattern
    {
        private List<Word> verbs;
        private Random rnd;

        public void Initialize(List<Word> wordlist, Random random)
        {
            rnd = random;
            verbs = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.v).ToList();
        }

        public string GetPattern()
        {
            return string.Format("{0}.{1}.and.{2}", verbs[rnd.Next(verbs.Count)].Lemma, verbs[rnd.Next(verbs.Count)].Lemma, verbs[rnd.Next(verbs.Count)].Lemma);

        }

        public string GetPatternTitle()
        {
            return "Verb.Verb.And.Verb";
        }
    }
}
