using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListasObjetos.Exercício02
{
    internal class AlunoController
    {
        private AlunoServico alunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            int codigo = 0;
            while(codigo != 13)
            {
                Console.Clear();

                codigo = Menu();

                Console.Clear();

                //05 - OBTER O NOME DOS ALUNOS
                //06 - OBTER A MEDIA DA NOTA DOS ALUNOS
                //07 - OBTER OS ALUNOS APROVADOS
                //08 - OBTER OS ALUNOS REPROVADOS
                //09 - OBTER OS ALUNOS EM EXAME
                //10 - OBTER A MEDIA DAS NOTAS POR CÓDIGO DE MATRÍCULA
                //11 - OBTER STATUS DO ALUNO POR CÓDIGO DE MATRÍCULA
                //12 - OBTER A MEDIA DAS IDADES DOS ALUNOS
                //13 - Sair"

                if (codigo == 1)
                    AdicionarAluno();

                else if (codigo == 2)
                    RemoverAluno();

                else if (codigo == 3)
                    EditarDadosCadastrais();

                else if (codigo == 4)
                    EditarNotasAlunos();
                    
                    

            }
        }

        private void RemoverAluno()
        {
            ObterTodosAlunos();

            Console.WriteLine("Informe o nome do aluno que deseja remover o cadastro: ");
            var nomeAluno = Console.ReadLine();

            var nomeApagado = alunoServico.RemoverAluno(nomeAluno);

            Console.WriteLine(nomeApagado == true
                ? "Cadastro do aluno removido com sucesso"
                : "Nenhum aluno como esse código de matrícula cadastrado");
        }

        public void AdicionarAluno()
        {
            Console.WriteLine("Informe o nome do aluno que deseja cadastrar: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o código de matrícula do aluno: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a matéria favorita do aluno: ");
            var materiaFavorita = Console.ReadLine();

            Console.WriteLine("Informe a idade do aluno: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota do aluno: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota do aluno: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota do aluno: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            alunoServico.AdicionarAluno(nome, codigoMatricula, materiaFavorita, idade, nota1, nota2, nota3);
        }

        public void EditarDadosCadastrais()
        {
            ObterTodosAlunos();

            Console.WriteLine("Informe o nome do aluno: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o código de matrícula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a idade do aluno: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a matéria favorita do aluno: ");
            var materiaFavorita = Console.ReadLine();


            var alterado = alunoServico.EditarDadosCadastrais(codigoMatricula, nome, idade, materiaFavorita);

            if(alterado == false)
                Console.WriteLine("Código de matrícula não existe");

            else
                Console.WriteLine("Cadastro do aluno atualizado com sucesso");
        }

        public void EditarNotasAlunos()
        {
            ObterTodosAlunos();


            Console.WriteLine("Informe o código de matrícula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota do aluno: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            var alterado = alunoServico.EditarNotasAlunos(codigoMatricula, nota1, nota2, nota3);

            if(alterado == false)
                Console.WriteLine("Código de matrícula não existe");

            else
                Console.WriteLine("Cadastro do aluno atualizado com sucesso");
        }

        private int Menu()
        {
            Console.WriteLine(@"   MENU
01 - ADICIONAR ALUNO
02 - REMOVER ALUNO
03 - EDITAR DADOS CADASTRAIS DO ALUNO
04 - EDITAR NOTAS DOS ALUNOS
05 - OBTER O NOME DOS ALUNOS
06 - OBTER A MEDIA DA NOTA DOS ALUNOS
07 - OBTER OS ALUNOS APROVADOS
08 - OBTER OS ALUNOS REPROVADOS
09 - OBTER OS ALUNOS EM EXAME
10 - OBTER A MEDIA DAS NOTAS POR CÓDIGO DE MATRÍCULA
11 - OBTER STATUS DO ALUNO POR CÓDIGO DE MATRÍCULA
12 - OBTER A MEDIA DAS IDADES DOS ALUNOS
13 - Sair");

            var codigo = SolicitarCodigo();
            return codigo;
        }

        private int SolicitarCodigo()
        {
            var codigo = 0;
            while(codigo < 1 || codigo > 13)
            {
                try
                {
                    Console.WriteLine("Digite o menu desejado: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Menu desejado não é válido, digite o menu novamente");
                }
            }
            return codigo;
        }

        private void ObterTodosAlunos()
        {
            var alunos = alunoServico.ObterTodosAlunos();

            if(alunos.Count == 0)
            {
                Console.WriteLine("Não foi cadastrado nenhum alunos no momento");
                return;
            }

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                Console.WriteLine($@"
Nome do aluno: {alunoAtual.Nome}
Código de matrícula: {alunoAtual.CodigoMatricula}
Idade do aluno: {alunoAtual.Idade}
Matéria favorita do aluno: {alunoAtual.MateriaFavorita}
Primeira nota do aluno: {alunoAtual.Nota1}
Segunda nota do aluno: {alunoAtual.Nota2}
Terceira nota do aluno: {alunoAtual.Nota3}" + "\n");
                Console.WriteLine();
            }
        }
    }
}
