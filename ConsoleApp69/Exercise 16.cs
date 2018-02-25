using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                for (int k = 0; k <= i; k++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
