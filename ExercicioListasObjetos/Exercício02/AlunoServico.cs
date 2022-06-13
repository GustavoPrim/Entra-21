using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListasObjetos.Exercício02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int codigoMatriculaAtual = 1;

        public void AdicionarAluno(string nome, int idade, string materiaFavorita, int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            aluno.CodigoMatricula = codigoMatriculaAtual;
            codigoMatriculaAtual = codigoMatriculaAtual + 1;
            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for (var i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];
                if (aluno.Nome == nome)
                {
                    alunos.Remove(aluno);

                    return true;
                }
            }
            return false;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            Aluno alunoAlterarDadosCadastrais = ObterAlunoPorCodigo(codigoMatricula);

            if (alunoAlterarDadosCadastrais == null)
                return false;

            alunoAlterarDadosCadastrais.Nome = nome;
            alunoAlterarDadosCadastrais.Idade = idade;
            alunoAlterarDadosCadastrais.MateriaFavorita = materiaFavorita;

            return true;
        }

        public bool EditarNotasAlunos(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno alunoAlterarNotas = ObterAlunoPorCodigo(codigoMatricula);

            if (alunoAlterarNotas == null)
                return false;

            alunoAlterarNotas.Nota1 = nota1;
            alunoAlterarNotas.Nota2 = nota2;
            alunoAlterarNotas.Nota3 = nota3;

            return true;
        }

        public List<Aluno> ObterTodosAlunos()
        {
            return alunos;
        }

        public Aluno ObterAlunoPorCodigo(int codigoMatricula)
        {
            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoSelecionado = alunos[i];

                if (alunoSelecionado.CodigoMatricula == codigoMatricula)
                    return alunoSelecionado;
            }
            return null;
        }

        public List<string> ObterNomesAlunos()
        {
            var nomes = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                nomes.Add(aluno.Nome);
            }
            return nomes;
        }

        //public List<double> ObterMediasAlunos()
        //{
        //    var medias = new List<double>();

        //    for (var i = 0; i < alunos.Count; i++)
        //    {
        //        var aluno = alunos[i];

        //        medias.Add(aluno.)
        //    }
        //}
    }
}
