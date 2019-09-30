using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Triangulo : Figura
    {
        private double Base;
        private double Altura;
        private double Lado2;
        private double Lado3;
        public Triangulo(double Base, double Altura, double Lado2, double Lado3)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.Lado2 = Lado2;
            this.Lado3 = Lado3;
            Nombre = "Triangulo";
        }
        public double calcularArea()
        {
            return (Base * Altura) / 2;
        }

        public double calcularPerimetro()
        {
            return Base + Lado2 + Lado3;
        }
    }
}
