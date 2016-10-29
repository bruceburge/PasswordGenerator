using System;

namespace PasswordGenerator
{
    public class VerbTheNounAndVerbTheNoun : IPasswordPattern
    {
        private Random rnd;

        public void Initialize(Random random)
        {
            rnd = random;
        }

        public string GetPattern()
        {
            var verbTheNoun = new VerbTheNoun();
            verbTheNoun.Initialize(rnd);
            return string.Format(
                "{0}.{1}.{2}",
                verbTheNoun.GetPattern(),
                "And",
                verbTheNoun.GetPattern());
        }

        public string GetPatternTitle()
        {
            return "Verb.The.Noun.And.Verb.The.Noun";
        }
    }
}