namespace Questao1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Saudar()
        {
            return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";
        }

        public void FazerAniversario()
        {
            Idade++;
        }
    }
}