using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo17
    {
        static void Main(string[] args)
        {
            string s, reverse = "";
            Console.WriteLine(" Enter the word");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i].ToString();
            }

            Console.WriteLine(reverse);


        }
    }
}
