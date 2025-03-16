using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solução para as questões 2, 3, 4, 5 e 6
            
            Ingresso ingressoXuxa = new Ingresso("Show da Xuxa", 200, 1000);
            Ingresso ingressoSandyJunior = new Ingresso("Show da Sandy & Junior", 300, 700);
            
            Console.WriteLine("[SHOWS DISPONÍVEIS]");
            Console.WriteLine(ingressoXuxa.ExibirInformacoes());
            Console.WriteLine(ingressoSandyJunior.ExibirInformacoes());

            ingressoXuxa.AlterarQuantidade(300);
            ingressoXuxa.SetPreco(550);

            ingressoSandyJunior.SetQuantidadeDisponivel(420);
            ingressoSandyJunior.AlterarPreco(470);

            Console.WriteLine("\n[SHOWS QUASE ESGOTADOS - INFORMAÇÕES ATUALIZADAS]");
            Console.WriteLine(ingressoXuxa.ExibirInformacoes());
            Console.WriteLine(ingressoSandyJunior.ExibirInformacoes());

            ingressoXuxa.SetPreco(600);
            
            Console.WriteLine("\n[ULTIMOS INGRESSOS PARA O SHOW DA XUXA]");
            Console.WriteLine($"Valor atualizado: R$ {ingressoXuxa.GetPreco():F2}");

            Console.ReadLine();
        }
    }
}
