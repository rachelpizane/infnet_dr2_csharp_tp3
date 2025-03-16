using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Program
    {
        static void Main()
        {
            // Solução para as questões 10, 11 e 12.
            Circulo circulo = new Circulo(3.0);
            double areaCirculo = circulo.CalcularArea();

            Esfera esfera = new Esfera(5.0);
            double volumeEsfera = esfera.CalcularVolume();

            Console.WriteLine("[CIRCULO]");
            Console.WriteLine($"Área: {areaCirculo:F2}\n");

            Console.WriteLine("[ESFERA]");
            Console.WriteLine($"Volume: {volumeEsfera:F2}");

            Console.ReadLine();
        }
    }
}
