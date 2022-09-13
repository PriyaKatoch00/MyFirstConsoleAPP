using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo12
    {
        static void Main(string[] args)
        {
            for (int i = 201; i < 300; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
