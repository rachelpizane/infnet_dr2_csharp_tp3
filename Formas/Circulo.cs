using System;

namespace Formas
{
    public class Circulo
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
