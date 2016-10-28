using System;

namespace PasswordGenerator
{
    public class Blank : IPasswordPattern
    {
        public string GetPattern()
        {
            return string.Empty;
        }

        public string GetPatternTitle()
        {
            return "Blank";
        }

        public void Initialize(Random random)
        {
        }
    }
}