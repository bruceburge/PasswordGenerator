﻿using System;

namespace PasswordGenerator
{
    public class VerbTheNoun : IPasswordPattern
    {
        private Random rnd;

        public void Initialize(Random random)
        {
            rnd = random;
        }

        public string GetPattern()
        {
            return string.Format(
                "{0}.{1}.{2}",
                WordLibs.UppercaseWords(WordLibs.Verbs[rnd.Next(WordLibs.Verbs.Length)]),
                "The",
                WordLibs.UppercaseWords(WordLibs.Nouns[rnd.Next(WordLibs.Nouns.Length)]));
        }

        public string GetPatternTitle()
        {
            return "Verb.The.Noun";
        }
    }
}