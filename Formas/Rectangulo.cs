using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Rectangulo : Figura
    {
        public double Largo;
        public double Ancho;
        public Rectangulo(double Largo, double Ancho)
        {
            this.Largo = Largo;
            this.Ancho = Ancho;
            Nombre = "Rectangulo";
        }

        public double calcularArea()
        {
            return Largo * Ancho;
        }

        public double calcularPerimetro()
        {
            return (Largo * 2) + (Ancho * 2);
        }
    }
}
