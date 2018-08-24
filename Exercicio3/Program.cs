using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtdHoras, salMin,valorHora, salReceber;

            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            qtdHoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do salario minimo: ");
            salMin = double.Parse(Console.ReadLine());

            valorHora = salMin * 0.10;

            salReceber = valorHora * qtdHoras;
            salReceber = salReceber - (salReceber*0.03);
            Console.WriteLine("Você ira receber R${0}", salReceber);
            Console.ReadKey();

        }
    }
}
