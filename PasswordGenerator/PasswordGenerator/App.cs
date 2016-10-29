using System;
using Bridge.Html5;

namespace PasswordGenerator
{
    public class App
    {
        private static IPasswordPattern passwordPattern;

        public static void Main()
        {
            Random rnd = new Random();

            passwordPattern = null;

            var passwordLabel = new HTMLDivElement { Id = "passwordLabel" };
            var passwordList = new HTMLDivElement { Id = "passwords" };

            var button = new HTMLButtonElement
            {
                InnerHTML = "Generate Password",
                OnClick = (ev) =>
                {
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
                    passwordPattern.Initialize(rnd);
                    //Console.WriteLine(passwordPattern.GetPatternTitle());
                    passwordLabel.InnerHTML = " " + passwordPattern.GetPatternTitle();
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

            var div = new HTMLDivElement();
            div.AppendChild(clearButton);
            div.AppendChild(button);
            Document.Body.AppendChild(div);
            Document.Body.AppendChild(new HTMLBRElement());
            Document.Body.AppendChild(passwordList);
        }

        private static IPasswordPattern GetRandomPattern(Random rnd)
        {
            switch (rnd.Next(0, 5))
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

                case 3:
                    passwordPattern = new VerbTheNoun();
                    break;

                case 4:
                    passwordPattern = new VerbTheNounAndVerbTheNoun();
                    break;

                default:
                    passwordPattern = new NounVerbNoun();
                    break;
            }

            return passwordPattern;
        }
    }
}