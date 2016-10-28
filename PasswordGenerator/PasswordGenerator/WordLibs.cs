using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public static class WordLibs
    {

        public static string Numbers = "1234567890";
        public static string Vowels = "aeiou";
        public static string Consconsonants = "bcdfghjklmnpqrstwxyz";
        public static string CommonConsconsonants = "bcdfghjklmnprstwy";
        public static string Specials = "!@#$%^&*+=?.,:|~_-";
        public static string Letters = Consconsonants + Vowels;


        public static string[] Articles = { "the", "a", "one", "some", "any", };
        #region Pronouns
        public static string[] Pronouns =
        {
            "I",
            "you",
            "he",
            "she",
            "we",
            "they",
            "me",
            "you",
            "him",
            "her",
            "us",
            "them",
            "my",
            "your",
            "his",
            "her",
            "our",
            "their",
            "mine",
            "yours",
            "his",
            "hers",
            "ours",
            "theirs"
        };
        #endregion
        #region Nouns
        public static string[] Nouns =
        {
            "time",
            "year",
            "people",
            "way",
            "day",
            "man",
            "thing",
            "woman",
            "life",
            "child",
            "world",
            "school",
            "state",
            "family",
            "student",
            "group",
            "country",
            "problem",
            "hand",
            "part",
            "place",
            "case",
            "week",
            "company",
            "system",
            "program",
            "question",
            "work",
            "government",
            "number",
            "night",
            "mister",
            "point",
            "home",
            "water",
            "room",
            "mother",
            "area",
            "money",
            "story",
            "fact",
            "month",
            "lot",
            "right",
            "study",
            "book",
            "eye",
            "job",
            "word",
            "business",
            "issue",
            "side",
            "kind",
            "head",
            "house",
            "service",
            "friend",
            "father",
            "power",
            "hour",
            "game",
            "line",
            "end",
            "member",
            "law",
            "car",
            "city",
            "community",
            "name",
            "president",
            "team",
            "minute",
            "idea",
            "kid",
            "body",
            "information",
            "back",
            "parent",
            "face",
            "others",
            "level",
            "office",
            "door",
            "health",
            "person",
            "art",
            "war",
            "history",
            "party",
            "result",
            "change",
            "morning",
            "reason",
            "research",
            "girl",
            "guy",
            "food",
            "moment",
            "air",
            "teacher"
        };

        #endregion
        #region Verbs
        public static string[] Verbs =
        {
            "be",
            "have",
            "do",
            "say",
            "get",
            "make",
            "go",
            "see",
            "know",
            "take",
            "think",
            "come",
            "give",
            "look",
            "use",
            "find",
            "want",
            "tell",
            "put",
            "mean",
            "become",
            "leave",
            "work",
            "need",
            "feel",
            "seem",
            "ask",
            "show",
            "try",
            "call",
            "keep",
            "provide",
            "hold",
            "turn",
            "follow",
            "begin",
            "bring",
            "like",
            "going",
            "help",
            "start",
            "run",
            "write",
            "set",
            "move",
            "play",
            "pay",
            "hear",
            "include",
            "believe",
            "allow",
            "meet",
            "lead",
            "live",
            "stand",
            "happen",
            "carry",
            "talk",
            "appear",
            "produce",
            "sit",
            "offer",
            "consider",
            "expect",
            "suggest",
            "let",
            "read",
            "require",
            "continue",
            "lose",
            "add",
            "change",
            "fall",
            "remain",
            "remember",
            "buy",
            "speak",
            "stop",
            "send",
            "receive",
            "decide",
            "win",
            "understand",
            "describe",
            "develop",
            "agree",
            "open",
            "reach",
            "build",
            "involve",
            "spend",
            "return",
            "draw",
            "die",
            "hope",
            "create",
            "walk",
            "sell",
            "wait",
            "cause"
        };
        #endregion
        #region Past Verb
        public static string[] PastVerbs =
        {
            "awoke",
            "beat",
            "began",
            "bit",
            "blew",
            "broke",
            "brought",
            "built",
            "bought",
            "caught",
            "chose",
            "came",
            "cost",
            "cut",
            "did",
            "dealt",
            "dug",
            "dreamt",
            "drew",
            "drank",
            "drove",
            "ate",
            "fell",
            "fed",
            "felt",
            "fought",
            "found",
            "flew",
            "forgot",
            "forgave",
            "froze",
            "got",
            "gave",
            "went",
            "grew",
            "hung",
            "had",
            "heard",
            "hid",
            "hit",
            "held",
            "hurt",
            "kept",
            "knew",
            "laid",
            "led",
            "left",
            "lent",
            "let",
            "lay",
            "lost",
            "made",
            "meant",
            "met",
            "paid",
            "put",
            "quit",
            "read",
            "rode",
            "rang",
            "rose",
            "ran",
            "said",
            "saw",
            "sought",
            "sold",
            "sent",
            "set",
            "sewed",
            "shook",
            "shone",
            "shot",
            "showed",
            "sang",
            "sank",
            "sat",
            "slept",
            "slid",
            "spoke",
            "spent",
            "spread",
            "stood",
            "stole",
            "stuck",
            "struck",
            "swore",
            "swept",
            "swelled",
            "swam",
            "swung",
            "took",
            "taught",
            "tore",
            "told",
            "thought",
            "wore",
            "wept",
            "won",
            "wrote"
    };
        #endregion

        public static string[] Prepositions = { "to", "from", "over", "under", "on", };

        /// <summary>
        /// Upcase first letter in a word
        /// https://www.dotnetperls.com/uppercase-first-letter
        /// </summary>
        /// <param name="value">word to upcase</param>
        /// <returns>upcased word</returns>
        public static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}
