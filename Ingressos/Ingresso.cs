using System;

namespace Ingressos
{
    public class Ingresso
    {
        private string NomeDoShow;
        private double Preco;
        private int QuantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            NomeDoShow = nomeDoShow;
            Preco = preco;
            QuantidadeDisponivel = quantidadeDisponivel;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            QuantidadeDisponivel = novaQuantidade;
        }

        public void AlterarPreco(int novoPreco)
        {
            Preco = novoPreco;
        }

        public string ExibirInformacoes()
        {
            return $"Nome do show: {NomeDoShow} | Preço: R$ {Preco:F2} | Quantidade disponível: {QuantidadeDisponivel}";
        }

        public string GetNomeDoShow()
        {
            return NomeDoShow;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return QuantidadeDisponivel;
        }

        public void SetNomeDoShow(string nomeDoShow)
        {
            NomeDoShow = nomeDoShow;
        }

        public void SetPreco(double preco)
        {
            Preco = preco;
        }

        public void SetQuantidadeDisponivel(int quantidadeDisponivel)
        {
            QuantidadeDisponivel = quantidadeDisponivel;
        }
    }
}
