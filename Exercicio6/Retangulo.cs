using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Retangulo
    {
        public double ladoA;
        public double ladoB;

        public bool MudaLados(double valor, double valor2)
        {
            this.ladoA = valor;
            this.ladoB = valor2;

            return true;
        }

        public double RetornarLadoA() {

            return this.ladoA;
        }
        public double RetornarLadoB()
        {

            return this.ladoB;
        }

        public double Area (){
            double areat = this.ladoA * this.ladoB;

            return areat;
}

        public double Perimetro() {
             double perit = ladoA * 2 + ladoB * 2;
            return perit;
             
        }
    }
}
