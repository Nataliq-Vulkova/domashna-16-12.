using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n =int.Parse(Console.ReadLine());
            Console.Write("Въведи символ: ");
            var b = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(b);
                for (int c = 1; c < i; c++)
                    Console.Write(b);
                Console.WriteLine();
            }

        }
    }
}
