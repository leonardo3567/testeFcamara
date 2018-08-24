using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double tamanhoPintar,precototal,litrosNecessarios;
            //entrada de dados
            Console.WriteLine("Digite o area em m2 a ser calculada: ");
            tamanhoPintar = double.Parse(Console.ReadLine());
            //calculo quantidade de litros
            litrosNecessarios = tamanhoPintar / 3.0;
            //calculo quantidades de latas
            litrosNecessarios = litrosNecessarios / 18;
            //arredondamento pra cima
            litrosNecessarios = Math.Ceiling(litrosNecessarios);
            //calculo preco total
            precototal = litrosNecessarios * 80;
            Console.WriteLine("Serão necessarias {0} latas de tinta que totalizarão R${1},00",litrosNecessarios,precototal);



            Console.ReadKey();
        }
    }
}
