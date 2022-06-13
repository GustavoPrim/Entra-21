namespace Entra21.ExercicioListasObjetos.Exercício02
{
    internal class Aluno
    {
        public string Nome, MateriaFavorita;
        public int CodigoMatricula, Idade;
        public double Nota1, Nota2, Nota3;

        public double CalcularMedia()
        {
            var media = (Nota1 + Nota2 + Nota3) / 3.0;

            return media;
        }

        public AlunoStatus ObterStatus()
        {
            var status = CalcularMedia();

            if (status >= 7)
                return AlunoStatus.Aprovado;

            else if (status < 6)
                return AlunoStatus.Reprovado;

            else
                return AlunoStatus.EmExame;
        }
    }
}
