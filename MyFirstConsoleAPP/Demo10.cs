using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo10
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            for (int i = 5; i <= n; i++)
            {
                n1 = n1 + i * i * i;
            }
            Console.WriteLine(n1);
        }
    }
}
