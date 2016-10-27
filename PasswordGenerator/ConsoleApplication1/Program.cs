using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Word> tmp = new WordList().LoadWordList();

            Console.WriteLine(new nounVerbNoun().GetPattern(tmp, rnd));
            
        }
    }
}
