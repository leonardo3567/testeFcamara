using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta co = new Conta();
            co.numeroConta = 1;
            co.nomeCorrentista = "Leo";
            co.saldo = 0;
            Console.WriteLine("Nome: {0},Numero de conta: {1}, Saldo: R${2},00",co.nomeCorrentista,co.numeroConta,co.saldo);
            co.Deposito(330);
            Console.WriteLine("Nome: {0},Numero de conta: {1}, Saldo: R${2},00", co.nomeCorrentista, co.numeroConta, co.saldo);

            co.Altera("Leonardo");
            co.Saque(200);
            Console.WriteLine("Nome: {0},Numero de conta: {1}, Saldo: R${2},00", co.nomeCorrentista, co.numeroConta, co.saldo);

            Console.ReadKey();
        }
    }
}
