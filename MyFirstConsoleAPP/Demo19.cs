using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo19
    {
        static void Main(string[] args)
        {
            String w = Console.ReadLine();
            int n = w.Length;
            int flag = 1;
            for (int i = 0; i < n / 2; i++)
            {
                if (w[i] != w[n - 1 - i])
                    flag = -1;
            }
            if (flag == 1)
                Console.WriteLine("Pallindrome");
            else
                Console.WriteLine("not Pallindrome");
        }
    }
}
