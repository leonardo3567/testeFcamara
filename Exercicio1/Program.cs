using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salFunc = 1000, aumento = 0.015;

            salFunc += salFunc * aumento;
            Console.WriteLine(salFunc);
            //loop aumento pensei em 12 anos a partir de 2007
            for (int i = 0; i < 12; i++)
            {
                aumento = aumento * 2;
                salFunc += salFunc * aumento;

            }
            Console.WriteLine("Salario atual: " + salFunc);
            Console.ReadKey();
        }
    }
}
