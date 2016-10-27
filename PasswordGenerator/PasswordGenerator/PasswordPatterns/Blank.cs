using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Blank : IPasswordPattern
    {
        public string GetPattern()
        {
            return string.Empty;
        }

        public string GetPatternTitle()
        {
            return "Blank";
        }

        public void Initialize(List<Word> wordlist, Random random)
        {

        }
    }
}
