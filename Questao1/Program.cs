using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Program
    {
        static void Main()
        {
            Pessoa joao = new Pessoa("Joao", 14);

            Console.WriteLine(joao.Saudar());
            joao.FazerAniversario();

            Console.WriteLine(joao.Saudar());
            Console.ReadLine();
        }
    }
}
