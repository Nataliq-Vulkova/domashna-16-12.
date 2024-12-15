using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            int r = 2;
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 3 && n <= 102)
            {
                while (r <= n)
                {
                    c = c + r;
                    r++;
                }
                Console.WriteLine("c= " + c);
            }

        }
    }
}
