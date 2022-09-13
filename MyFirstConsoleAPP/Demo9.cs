using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo9
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, i;

            Console.Write(f1 + " ");
            for (i = 1; i < 40; i++)
            {
                Console.Write(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
        }
        }
}
