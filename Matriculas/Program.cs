using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas
{
    class Program
    {
        static void Main()
        {
            // Solução das questões 7,8 e 9

            Matricula matricula = new Matricula("Joao", "Engenharia", 104, "Ativa", "01/01/2025");

            Console.WriteLine("[MATRICULA CRIADA]");
            Console.WriteLine(matricula.ExibirInformacoes());

            matricula.Trancar();

            Console.WriteLine("[MATRICULA TRANCADA]");
            Console.WriteLine(matricula.ExibirInformacoes());

            matricula.Reativar();
            
            Console.WriteLine("[MATRICULA REATIVADA]");
            Console.WriteLine(matricula.ExibirInformacoes());
            Console.ReadLine();
        }
    }
}
