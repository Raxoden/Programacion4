using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Cuadrado : Figura
    {
        public double Lado;
        public Cuadrado(double Lado)
        {
            this.Lado = Lado;
            Nombre = "Cuadrado";
        }

        public double calcularArea()
        {
            return Lado * Lado;
        }

        public double calcularPerimetro()
        {
            return Lado * 4;
        }
    }
}
