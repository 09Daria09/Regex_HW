using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Regex_HW
{
    internal class Program
    {
        static void findMyText(string text, MatchCollection myMatch)
        {           
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Console.Write(text[i]);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void Find(string str,params string[] wordLookFor)
        {
            foreach (string word in wordLookFor)
            {
                MatchCollection match = Regex.Matches(str, word);
                findMyText(str, match);
                Console.WriteLine();
            }               
        }
        public static void EdgeA(string str)
        {
            string Reg = @"a..a";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        public static void EdgeAWithoutC(string str) 
        {
            string Reg = @"a.(?!c).a";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        public static void AandB(string str)
        {
            string Reg = @"ab+a";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        public static void AandBBB(string str)
        {
            string Reg = @"ab*a";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        public static void AandBorWithoutB(string str)
        {
            string Reg = @"ab*?a";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        public static void AandBorWithoutBShort(string str)
        {
            string Reg = @"ab?a";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        public static void StrAB(string str)
        {
            string Reg = @"\bab\b";
            MatchCollection match = Regex.Matches(str, Reg);
            findMyText(str, match);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            Find("ahb acb aeb aeeb adcb axeb", "ahb","acb","aeb");
            Console.WriteLine("№2");
            EdgeA("aba aca aea abba adca abea");
            Console.WriteLine("№3");
            EdgeAWithoutC("aba aca aea abba adca abea");
            Console.WriteLine("№4");
            AandB("aa aba abba abbba abca abea");
            Console.WriteLine("№5");
            AandBorWithoutB("aa aba abba abbba abca abea");
            Console.WriteLine("№6");
            AandBorWithoutBShort("aa aba abba abbba abca abea");
            Console.WriteLine("№7");
            Console.WriteLine("Такой метод уже есть ._.");
            AandBorWithoutB("aa aba abba abbba abca abea");
            Console.WriteLine("№8");
            StrAB("ab abab abab ab ababababab abea");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Мне нравятся такие задания :), а такие, как SOLID, не нравятся :(");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
