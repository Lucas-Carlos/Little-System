using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telaLogin.cs
{
    class Calculadora
    {
        private double n1;
        private double n2;
        private double n3;
        private double n4;
        private double n5;
        private double resul;

        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }
        public double N3 { get => n3; set => n3 = value; }
        public double N4 { get => n4; set => n4 = value; }
        public double N5 { get => n5; set => n5 = value; }
        public double Resul { get => resul; set => resul = value; }

        public double calcularMediade2()
        {
            resul = (this.N1 + this.N2) / 2;
            return (resul);
        }

        public double calcularMediade3()
        {
            resul = (this.N1 + this.N2 + this.N3) / 3;
            return (resul);
        }

        public double calcularMediade4()
        {
            resul = (this.N1 + this.N2 + this.N3 + this.N4) / 4;
            return (resul);
        }

        public double calcularMediade5()
        {
            resul = (this.N1 + this.N2 + this.N3 + this.N4 + this.N5) / 5;
            return (resul);
        }
    }
}
