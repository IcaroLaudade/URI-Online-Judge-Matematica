using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1240
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                string[] txt = Console.ReadLine().Split(' ');
                char[] texto1 = txt[0].ToCharArray();
                char[] texto2 = txt[1].ToCharArray();
                int total = 0 + (texto1.Length - texto2.Length);
                int contador = 0;
                if (total < 0)
                {
                    Console.WriteLine("nao encaixa");
                }
                else
                {
                    for (int j = total; j < texto1.Length; j++)
                    {
                        if (!texto1[j].Equals(texto2[contador]))
                        {
                            Console.WriteLine("nao encaixa");
                            break;
                        }
                        if (j == texto1.Length - 1 && texto1[j].Equals(texto2[contador]))
                        {
                            Console.WriteLine("encaixa");
                        }
                        contador++;
                    }
                }
            }
        }
    }
}
