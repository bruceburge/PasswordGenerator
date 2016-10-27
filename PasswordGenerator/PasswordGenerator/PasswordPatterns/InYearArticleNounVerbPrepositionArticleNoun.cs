using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class InYearArticleNounVerbPrepositionArticleNoun : IPasswordPattern
    {
        private List<Word> nouns;
        private List<Word> verbs;
        private List<Word> articles;
        private List<Word> prepositions;

        private Random rnd;

        public void Initialize(List<Word> wordlist, Random random)
        {
            rnd = random;

            nouns = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.n).ToList();
            verbs = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.v).ToList();
            articles = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.a).ToList();
            prepositions = wordlist.Where(x => x.PartOfSpeech == PartsOfSpeech.i).ToList();

        }

        public string GetPattern()
        {
            var a1 = articles[rnd.Next((articles.Count))].Lemma;
            var n1 = nouns[rnd.Next((nouns.Count))].Lemma;
            var v1 = verbs[rnd.Next((verbs.Count))].Lemma;
            var p1 = prepositions[rnd.Next((prepositions.Count))].Lemma;
            var a2 = articles[rnd.Next((articles.Count))].Lemma;
            var n2 = nouns[rnd.Next((nouns.Count))].Lemma;

            return string.Format("{0}.{1}.{2}.{3}.{4}.{5}.{6}", "In." + rnd.Next(1400, 2000), a1, n1, v1, p1, a2, n2);
        }

        public string GetPatternTitle()
        {
            return "In.Year.Article.Noun.Verb.Preposition.Article.Noun";
        }
    }
}
