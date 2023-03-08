using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace dz_03._03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Зад 1
            string task_1 = "ahb acb aeb aeeb adcb axeb";
            string reg_1 = @"^a\wb$";
            MatchCollection match_1 = Regex.Matches(task_1, reg_1);
            findMyText(task_1, match_1);
            Console.WriteLine();
            #endregion

            #region Зад 2
            string task_2 = "aba aca aea abba adca abea";
            string reg_2 = @"a..a";
            MatchCollection match_2 = Regex.Matches(task_2, reg_2);
            findMyText(task_2, match_2);
            Console.WriteLine();
            #endregion

            #region 3
            string task_3 = "aba aca aea abba adca abea";
            string reg_3 = @"a.(?!c).a";
            MatchCollection match_3 = Regex.Matches(task_3, reg_3);
            findMyText(task_3, match_3);
            Console.WriteLine();
            #endregion

            #region Зад 4
            string task_4 = "aa aba abba abbba abca abea";
            string reg_4 = @"ab+a";
            MatchCollection match_4 = Regex.Matches(task_4, reg_4);
            findMyText(task_4, match_4);
            Console.WriteLine();
            #endregion

            #region 5
            string task_5 = "aa aba abba abbba abca abea";
            string reg_5 = @"ab*?a";
            MatchCollection match_5 = Regex.Matches(task_5, reg_5);
            findMyText(task_5, match_5);
            Console.WriteLine();
            #endregion

            #region Зад 6
            string task_6 = "aa aba abba abbba abca abea";
            string reg_6 = @"ab?a";
            MatchCollection match_6 = Regex.Matches(task_6, reg_6);
            findMyText(task_6, match_6);
            Console.WriteLine();
            #endregion

            #region Зад 7
            string task_7 = "aa aba abba abbba abca abea";
            MatchCollection match_7 = Regex.Matches(task_7, reg_6);
            findMyText(task_7, match_6);
            Console.WriteLine();
            #endregion

            #region Зад 8
            string task_8 = "ab abab abab ab ababababab abea";
            string reg_8 = @"\bab\b";
            MatchCollection match_8 = Regex.Matches(task_8, reg_8);
            findMyText(task_8, match_8);
            Console.WriteLine();
            #endregion
        }
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

        }
    }
}
