using System;
using Bridge;
using Bridge.Html5;
using System.Collections.Generic;

namespace PasswordGenerator
{
    public class App
    {
        static IPasswordPattern passwordPattern;

        public static void Main()
        {
            Random rnd = new Random();
            //get word list
            List<Word> tmp = new WordList().LoadWordList();

            passwordPattern = null;

            var passwordLabel = new HTMLDivElement { Id = "passwordLabel" };
            var passwordList = new HTMLDivElement { Id = "passwords" };


            var button = new HTMLButtonElement
            {

                InnerHTML = "Generate Password",
                OnClick = (ev) =>
                {
                    //call gen
                    //Console.WriteLine(passwordPattern.GetPattern());
                    passwordList.InnerHTML += passwordPattern.GetPattern() + "<br/>";
                }
            };
            button.Disabled = true;


            var patternButton = new HTMLButtonElement
            {
                InnerHTML = "Random Pattern",
                OnClick = (ev) =>
                {
                    passwordPattern = GetRandomPattern(rnd);
                    button.Disabled = false;
                    passwordPattern.Initialize(tmp, rnd);
                    //Console.WriteLine(passwordPattern.GetPatternTitle());
                    passwordLabel.InnerHTML = " "+passwordPattern.GetPatternTitle();
                }
            };

            var clearButton = new HTMLButtonElement
            {
                InnerHTML = "clear password list",
                OnClick = (ev) =>
                {
                    passwordList.InnerHTML = string.Empty;
                }
            };


            Document.BgColor = "black";
            Document.FgColor = "White";

            Document.Body.AppendChild(patternButton);
            Document.Body.AppendChild(passwordLabel);
            Document.Body.AppendChild(new HTMLBRElement());

            Document.Body.AppendChild(clearButton);
            Document.Body.AppendChild(new HTMLBRElement());


            Document.Body.AppendChild(button);
            Document.Body.AppendChild(new HTMLBRElement());            
            Document.Body.AppendChild(passwordList);

            



        }

        private static IPasswordPattern GetRandomPattern(Random rnd)
        {
            switch (rnd.Next(0, 3))
            {
                case 0:
                    passwordPattern = new InYearArticleNounVerbPrepositionArticleNoun();
                    break;
                case 1:
                    passwordPattern = new VerbVerbAndVerb();
                    break;
                case 2:
                    passwordPattern = new NounVerbNoun();
                    break;

                default:
                    passwordPattern = new NounVerbNoun();
                    break;
            }

            return passwordPattern;
        }
    }
}