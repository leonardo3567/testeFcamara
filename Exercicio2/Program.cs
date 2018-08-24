using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inic, fim;

            do
            {
                Console.WriteLine("Digite o começo do intervalo: ");
                inic = int.Parse(Console.ReadLine());




                if (inic>0)
                {
                    Maior:
                    Console.WriteLine("Digite o fim  do intervalo: ");
                    fim = int.Parse(Console.ReadLine());

                    if (fim >inic)

                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O fim deve ser maior que o inicio.");
                        goto Maior;

                    }
                }
                else
                {
                    Console.WriteLine("O numero deve ser maior que 0");
                }
            } while (true);
            for (int i = inic; i <= fim; i++)
            {
                int primo = 0;

                // Console.Write(i);
                for (int f = 1; f <= i; f++)
                {
                    if(i%f == 0)
                    {
                        primo++;
                    }
                }

                if(primo<=2)
                { Console.Write(i+" ");
                }
               
            }

            Console.ReadKey();
        }
    }
}
