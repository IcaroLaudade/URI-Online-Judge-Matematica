using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2149
{
    class Program
    {
        static void Main(string[] args)
        {
             string line;
             long[] valores = new long[17];
             valores[0] = 0;
             valores[1] = 1;
             valores[2] = 1;
             for (int i = 3; i < valores.Length; i++) {
                 if (i % 2 == 1)
                 {
                     valores[i] = valores[i - 1] * valores[i - 2];
                 }
                 else {
                     valores[i] = valores[i - 1] + valores[i - 2];
                 }
             }
                 while ((line = System.Console.ReadLine()) != null)
                 {
                     int linha = int.Parse(line);
                     Console.WriteLine(valores[linha - 1]);
                 }

        }
    }
}
