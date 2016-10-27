using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class NounVerbNoun : IPasswordPattern
    {
        private List<Word> nouns;
        private List<Word> verbs;
        private Random rnd;

        public void Initialize(List<Word> wordlist, Random random)
        {
            rnd = random;

            nouns = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.n).ToList();
            verbs = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.v).ToList();

        }

        public string GetPattern()
        {
            return string.Format("{0}.{1}.{2}", nouns[rnd.Next((int)(nouns.Count / 2))].Lemma, verbs[rnd.Next((int)(verbs.Count / 2))].Lemma, nouns[rnd.Next((int)(nouns.Count / 2))].Lemma);
        }

        public string GetPatternTitle()
        {
            return "Noun.Verb.Noun";
        }
    }
}
