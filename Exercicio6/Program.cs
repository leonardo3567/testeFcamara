using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //nao entendi muito bem esse exe a questao do rodape e do piso me deixaram com duvidas em relacao ao que é pedido

            Retangulo re = new Retangulo();

            Console.WriteLine("Digite o lado A do retangulo: ");
            double retA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B do retangulo: ");
            double retB = double.Parse(Console.ReadLine());

            re.ladoA = retA;
            re.ladoB = retB;


            //assumi o tamanho de um piso como 100cmx100cm

           double  pisos = re.Area();

            Console.WriteLine("Area total:{0}m2", pisos);

            double rodape = re.Perimetro();

            Console.WriteLine("Rodapé: {0}m", rodape);

            Console.ReadKey();
        }
    }
}
