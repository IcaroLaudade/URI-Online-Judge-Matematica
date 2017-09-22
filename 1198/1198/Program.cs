using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1198
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            while ((line = System.Console.ReadLine()) != null)
            {
                string[] linha = line.Split(' ');
                long a = long.Parse(linha[0]);
                long b = long.Parse(linha[1]);
                long c = a - b;
                if (c > 0)
                {
                    Console.WriteLine(c);
                }
                else {
                    Console.WriteLine(c * -1);
                }
            }
        }
    }
}
