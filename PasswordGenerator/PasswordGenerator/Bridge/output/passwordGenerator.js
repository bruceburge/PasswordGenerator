/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2016
 * @compiler Bridge.NET 15.3.0
 */
Bridge.assembly("PasswordGenerator", function ($asm, globals) {
    "use strict";

    Bridge.define("PasswordGenerator.App", {
        statics: {
            passwordPattern: null,
            getRandomPattern: function (rnd) {
                switch (rnd.next$2(0, 3)) {
                    case 0: 
                        PasswordGenerator.App.passwordPattern = new PasswordGenerator.InYearArticleNounVerbPrepositionArticleNoun();
                        break;
                    case 1: 
                        PasswordGenerator.App.passwordPattern = new PasswordGenerator.VerbVerbAndVerb();
                        break;
                    case 2: 
                        PasswordGenerator.App.passwordPattern = new PasswordGenerator.NounVerbNoun();
                        break;
                    default: 
                        PasswordGenerator.App.passwordPattern = new PasswordGenerator.NounVerbNoun();
                        break;
                }

                return PasswordGenerator.App.passwordPattern;
            }
        },
        $main: function () {
            var rnd = new System.Random.ctor();

            PasswordGenerator.App.passwordPattern = null;

            var passwordLabel = Bridge.merge(document.createElement('div'), {
                id: "passwordLabel"
            } );
            var passwordList = Bridge.merge(document.createElement('div'), {
                id: "passwords"
            } );

            var button = Bridge.merge(document.createElement('button'), {
                innerHTML: "Generate Password",
                onclick: function (ev) {
                    passwordList.innerHTML = System.String.concat(passwordList.innerHTML, (System.String.concat(PasswordGenerator.App.passwordPattern.PasswordGenerator$IPasswordPattern$getPattern(), "<br/>")));
                }
            } );
            button.disabled = true;

            var patternButton = Bridge.merge(document.createElement('button'), {
                innerHTML: "Random Pattern",
                onclick: function (ev) {
                    PasswordGenerator.App.passwordPattern = PasswordGenerator.App.getRandomPattern(rnd);
                    button.disabled = false;
                    PasswordGenerator.App.passwordPattern.PasswordGenerator$IPasswordPattern$initialize(rnd);
                    //Console.WriteLine(passwordPattern.GetPatternTitle());
                    passwordLabel.innerHTML = System.String.concat(" ", PasswordGenerator.App.passwordPattern.PasswordGenerator$IPasswordPattern$getPatternTitle());
                }
            } );

            var clearButton = Bridge.merge(document.createElement('button'), {
                innerHTML: "clear password list",
                onclick: function (ev) {
                    passwordList.innerHTML = "";
                }
            } );

            document.bgColor = "black";
            document.fgColor = "White";

            document.body.appendChild(patternButton);
            document.body.appendChild(passwordLabel);
            document.body.appendChild(document.createElement('br'));

            var div = document.createElement('div');
            div.appendChild(clearButton);
            div.appendChild(button);
            document.body.appendChild(div);
            document.body.appendChild(document.createElement('br'));
            document.body.appendChild(passwordList);
        }
    });

    Bridge.define("PasswordGenerator.IPasswordPattern", {
        $kind: "interface"
    });

    Bridge.define("PasswordGenerator.WordLibs", {
        statics: {
            numbers: "1234567890",
            vowels: "aeiou",
            consconsonants: "bcdfghjklmnpqrstwxyz",
            commonConsconsonants: "bcdfghjklmnprstwy",
            specials: "!@#$%^&*+=?.,:|~_-",
            letters: null,
            articles: null,
            pronouns: null,
            nouns: null,
            verbs: null,
            pastVerbs: null,
            prepositions: null,
            config: {
                init: function () {
                    this.letters = System.String.concat(PasswordGenerator.WordLibs.consconsonants, PasswordGenerator.WordLibs.vowels);
                    this.articles = ["the", "a", "one", "some", "any"];
                    this.pronouns = ["I", "you", "he", "she", "we", "they", "me", "you", "him", "her", "us", "them", "my", "your", "his", "her", "our", "their", "mine", "yours", "his", "hers", "ours", "theirs"];
                    this.nouns = ["time", "year", "people", "way", "day", "man", "thing", "woman", "life", "child", "world", "school", "state", "family", "student", "group", "country", "problem", "hand", "part", "place", "case", "week", "company", "system", "program", "question", "work", "government", "number", "night", "mister", "point", "home", "water", "room", "mother", "area", "money", "story", "fact", "month", "lot", "right", "study", "book", "eye", "job", "word", "business", "issue", "side", "kind", "head", "house", "service", "friend", "father", "power", "hour", "game", "line", "end", "member", "law", "car", "city", "community", "name", "president", "team", "minute", "idea", "kid", "body", "information", "back", "parent", "face", "others", "level", "office", "door", "health", "person", "art", "war", "history", "party", "result", "change", "morning", "reason", "research", "girl", "guy", "food", "moment", "air", "teacher"];
                    this.verbs = ["be", "have", "do", "say", "get", "make", "go", "see", "know", "take", "think", "come", "give", "look", "use", "find", "want", "tell", "put", "mean", "become", "leave", "work", "need", "feel", "seem", "ask", "show", "try", "call", "keep", "provide", "hold", "turn", "follow", "begin", "bring", "like", "going", "help", "start", "run", "write", "set", "move", "play", "pay", "hear", "include", "believe", "allow", "meet", "lead", "live", "stand", "happen", "carry", "talk", "appear", "produce", "sit", "offer", "consider", "expect", "suggest", "let", "read", "require", "continue", "lose", "add", "change", "fall", "remain", "remember", "buy", "speak", "stop", "send", "receive", "decide", "win", "understand", "describe", "develop", "agree", "open", "reach", "build", "involve", "spend", "return", "draw", "die", "hope", "create", "walk", "sell", "wait", "cause"];
                    this.pastVerbs = ["awoke", "beat", "began", "bit", "blew", "broke", "brought", "built", "bought", "caught", "chose", "came", "cost", "cut", "did", "dealt", "dug", "dreamt", "drew", "drank", "drove", "ate", "fell", "fed", "felt", "fought", "found", "flew", "forgot", "forgave", "froze", "got", "gave", "went", "grew", "hung", "had", "heard", "hid", "hit", "held", "hurt", "kept", "knew", "laid", "led", "left", "lent", "let", "lay", "lost", "made", "meant", "met", "paid", "put", "quit", "read", "rode", "rang", "rose", "ran", "said", "saw", "sought", "sold", "sent", "set", "sewed", "shook", "shone", "shot", "showed", "sang", "sank", "sat", "slept", "slid", "spoke", "spent", "spread", "stood", "stole", "stuck", "struck", "swore", "swept", "swelled", "swam", "swung", "took", "taught", "tore", "told", "thought", "wore", "wept", "won", "wrote"];
                    this.prepositions = ["to", "from", "over", "under", "on"];
                }
            },
            /**
             * Upcase first letter in a word
             https://www.dotnetperls.com/uppercase-first-letter
             *
             * @static
             * @public
             * @this PasswordGenerator.WordLibs
             * @memberof PasswordGenerator.WordLibs
             * @param   {string}    value    word to uppercase
             * @return  {string}             uppercased word
             */
            uppercaseWords: function (value) {
                var array = System.String.toCharArray(value, 0, value.length);
                // Handle the first letter in the string.
                if (array.length >= 1) {
                    if (Bridge.isLower(array[0])) {
                        array[0] = String.fromCharCode(array[0]).toUpperCase().charCodeAt(0);
                    }
                }
                // Scan through the letters, checking for spaces.
                // ... Uppercase the lowercase letters following spaces.
                for (var i = 1; i < array.length; i = (i + 1) | 0) {
                    if (array[((i - 1) | 0)] === 32) {
                        if (Bridge.isLower(array[i])) {
                            array[i] = String.fromCharCode(array[i]).toUpperCase().charCodeAt(0);
                        }
                    }
                }

                return String.fromCharCode.apply(null, array);
            }
        }
    });

    Bridge.define("PasswordGenerator.Blank", {
        inherits: [PasswordGenerator.IPasswordPattern],
        config: {
            alias: [
            "getPattern", "PasswordGenerator$IPasswordPattern$getPattern",
            "getPatternTitle", "PasswordGenerator$IPasswordPattern$getPatternTitle",
            "initialize", "PasswordGenerator$IPasswordPattern$initialize"
            ]
        },
        getPattern: function () {
            return "";
        },
        getPatternTitle: function () {
            return "Blank";
        },
        initialize: function (random) {
        }
    });

    Bridge.define("PasswordGenerator.InYearArticleNounVerbPrepositionArticleNoun", {
        inherits: [PasswordGenerator.IPasswordPattern],
        rnd: null,
        config: {
            alias: [
            "initialize", "PasswordGenerator$IPasswordPattern$initialize",
            "getPattern", "PasswordGenerator$IPasswordPattern$getPattern",
            "getPatternTitle", "PasswordGenerator$IPasswordPattern$getPatternTitle"
            ]
        },
        initialize: function (random) {
            this.rnd = random;
        },
        getPattern: function () {
            var a1 = PasswordGenerator.WordLibs.articles[this.rnd.next$1(PasswordGenerator.WordLibs.articles.length)];
            var n1 = PasswordGenerator.WordLibs.nouns[this.rnd.next$1(PasswordGenerator.WordLibs.nouns.length)];
            var pv1 = PasswordGenerator.WordLibs.pastVerbs[this.rnd.next$1(PasswordGenerator.WordLibs.pastVerbs.length)];
            var p1 = PasswordGenerator.WordLibs.prepositions[this.rnd.next$1(PasswordGenerator.WordLibs.prepositions.length)];
            var a2 = PasswordGenerator.WordLibs.articles[this.rnd.next$1(PasswordGenerator.WordLibs.articles.length)];
            var n2 = PasswordGenerator.WordLibs.nouns[this.rnd.next$1(PasswordGenerator.WordLibs.nouns.length)];

            return System.String.format("{0}.{1}.{2}.{3}.{4}.{5}.{6}", "In." + this.rnd.next$2(1400, 2000), a1, n1, pv1, p1, a2, n2);
        },
        getPatternTitle: function () {
            return "In.Year.Article.Noun.[past]Verb.Preposition.Article.Noun";
        }
    });

    Bridge.define("PasswordGenerator.NounVerbNoun", {
        inherits: [PasswordGenerator.IPasswordPattern],
        rnd: null,
        config: {
            alias: [
            "initialize", "PasswordGenerator$IPasswordPattern$initialize",
            "getPattern", "PasswordGenerator$IPasswordPattern$getPattern",
            "getPatternTitle", "PasswordGenerator$IPasswordPattern$getPatternTitle"
            ]
        },
        initialize: function (random) {
            this.rnd = random;
        },
        getPattern: function () {
            return System.String.format("{0}.{1}.{2}", PasswordGenerator.WordLibs.uppercaseWords(PasswordGenerator.WordLibs.nouns[this.rnd.next$1(PasswordGenerator.WordLibs.nouns.length)]), PasswordGenerator.WordLibs.verbs[this.rnd.next$1(PasswordGenerator.WordLibs.verbs.length)], PasswordGenerator.WordLibs.nouns[this.rnd.next$1(PasswordGenerator.WordLibs.nouns.length)]);
        },
        getPatternTitle: function () {
            return "Noun.Verb.Noun";
        }
    });

    Bridge.define("PasswordGenerator.VerbVerbAndVerb", {
        inherits: [PasswordGenerator.IPasswordPattern],
        rnd: null,
        config: {
            alias: [
            "initialize", "PasswordGenerator$IPasswordPattern$initialize",
            "getPattern", "PasswordGenerator$IPasswordPattern$getPattern",
            "getPatternTitle", "PasswordGenerator$IPasswordPattern$getPatternTitle"
            ]
        },
        initialize: function (random) {
            this.rnd = random;
        },
        getPattern: function () {
            return System.String.format("{0}.{1}.and.{2}", PasswordGenerator.WordLibs.uppercaseWords(PasswordGenerator.WordLibs.verbs[this.rnd.next$1(PasswordGenerator.WordLibs.verbs.length)]), PasswordGenerator.WordLibs.uppercaseWords(PasswordGenerator.WordLibs.verbs[this.rnd.next$1(PasswordGenerator.WordLibs.verbs.length)]), PasswordGenerator.WordLibs.uppercaseWords(PasswordGenerator.WordLibs.verbs[this.rnd.next$1(PasswordGenerator.WordLibs.verbs.length)]));
        },
        getPatternTitle: function () {
            return "Verb.Verb.And.Verb";
        }
    });
});
