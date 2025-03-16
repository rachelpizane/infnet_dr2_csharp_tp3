namespace Matriculas
{
    public class Matricula
    {
        private string NomeDoAluno;
        private string Curso;
        private int NumeroMatricula;
        private string Situacao;
        private string DataInicial;

        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            NomeDoAluno = nomeDoAluno;
            Curso = curso;
            NumeroMatricula = numeroMatricula;
            Situacao = situacao;
            DataInicial = dataInicial;
        }

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public string ExibirInformacoes()
        {
            return $"Nome do Aluno: {NomeDoAluno} | Curso: {Curso} | N�mero da Matr�cula: {NumeroMatricula} | Data inicial: {DataInicial} | Situa��o: {Situacao}\n";
        }
    }
}