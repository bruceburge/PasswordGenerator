using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class InYearArticleNounVerbPrepositionArticleNoun : IPasswordPattern
    {

        private Random rnd;

        public void Initialize(Random random)
        {
            rnd = random;

        }

        public string GetPattern()
        {
            var a1 = WordLibs.Articles[rnd.Next(WordLibs.Articles.Length)];
            var n1 = WordLibs.Nouns[rnd.Next(WordLibs.Nouns.Length)];
            var v1 = WordLibs.PastVerbs[rnd.Next(WordLibs.PastVerbs.Length)];
            var p1 = WordLibs.Prepositions[rnd.Next(WordLibs.Prepositions.Length)];
            var a2 = WordLibs.Articles[rnd.Next(WordLibs.Articles.Length)];
            var n2 = WordLibs.Nouns[rnd.Next(WordLibs.Nouns.Length)];

            return string.Format("{0}.{1}.{2}.{3}.{4}.{5}.{6}", "In." + rnd.Next(1400, 2000), a1, n1, v1, p1, a2, n2);
        }

        public string GetPatternTitle()
        {
            return "In.Year.Article.Noun.[past]Verb.Preposition.Article.Noun";
        }
    }
}
