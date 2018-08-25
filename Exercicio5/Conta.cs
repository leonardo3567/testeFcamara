using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Conta
    {
        public int numeroConta;
        public string nomeCorrentista;
        public double saldo;


        //alterarNome, depósito e saque;

        public bool Altera(String nome) {
            this.nomeCorrentista = nome;
            return true;

        }

        public bool Deposito(double valor) {
            this.saldo = this.saldo + valor;
            return true;
        }



        public bool Saque(double valor) {
            if (this.saldo > valor)
            {
                this.saldo = this.saldo - valor;
                return true;
            }
            else {
                return false; 
                    }
        }
    }
}
