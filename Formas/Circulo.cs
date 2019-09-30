using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }
        public Circulo(double Radio)
        {
            Nombre = "Circulo";
            this.Radio = Radio;
        }
        public double calcularArea()
        {
            return (Radio * Radio) * 3.1416;
        }

        public double calcularPerimetro()
        {
            return (Radio * 2) * 3.1416;
        }
    }
}
