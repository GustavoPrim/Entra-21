namespace Entra21.ExercicioListasObjetos.Exercício02
{
    internal class AlunoController
    {
        private AlunoServico alunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            int codigo = 0;
            while (codigo != 14)
            {
                Console.Clear();

                codigo = Menu();

                Console.Clear();
                //05 - OBTER ALUNO POR NOME
                //06 - OBTER ALUNO POR CÓDIGO
                //07 - OBTER A MEDIA DA NOTA DOS ALUNOS
                //08 - OBTER OS ALUNOS APROVADOS
                //09 - OBTER OS ALUNOS REPROVADOS
                //10 - OBTER OS ALUNOS EM EXAME
                //11 - OBTER A MEDIA DAS NOTAS POR CÓDIGO DE MATRÍCULA
                //12 - OBTER STATUS DO ALUNO POR CÓDIGO DE MATRÍCULA
                //13 - OBTER A MEDIA DAS IDADES DOS ALUNOS
                //14 - Sair"

                if (codigo == 1)
                    AdicionarAluno();

                else if (codigo == 2)
                    RemoverAluno();

                else if (codigo == 3)
                    EditarDadosCadastrais();

                else if (codigo == 4)
                    EditarNotasAlunos();

                //else if (codigo == 5)
                //    ObterAlunoPorNome();

                //else if (codigo == 6)
                //    ObterTodosAlunos();

                //else if (codigo == 7)
                //    ObterMediasNotas();

                //else if (codigo == 8)
                //    ObterAlunosAprovados();

                //else if (codigo == 9)
                //    ObterAlunosReprovados();

                //else if (codigo == 10)
                //    ObterAlunosEmExame();

                else if (codigo == 11)
                    ObterMediaPorCodigoMatricula();

                //else if (codigo == 12)
                //    ObterStatusPorCodigoMatricula();

                //else if (codigo == 13)
                //    ObterMediaIdades();

                Console.WriteLine("\n\nAperte alguma tecla para continuar");
                Console.ReadKey();
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

            if (alterado == false)
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

            var alunoEditado = alunoServico.ObterAlunoPorCodigo(codigoMatricula);

            if (alterado == false)
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
05 - OBTER ALUNO POR NOME
06 - OBTER TODOS OS ALUNOS
07 - OBTER A MEDIA DA NOTA DOS ALUNOS
08 - OBTER OS ALUNOS APROVADOS
09 - OBTER OS ALUNOS REPROVADOS
10 - OBTER OS ALUNOS EM EXAME
11 - OBTER A MEDIA DAS NOTAS POR CÓDIGO DE MATRÍCULA
12 - OBTER STATUS DO ALUNO POR CÓDIGO DE MATRÍCULA
13 - OBTER A MEDIA DAS IDADES DOS ALUNOS
14 - Sair");

            var codigo = SolicitarCodigo();
            return codigo;
        }

        private int SolicitarCodigo()
        {
            var codigo = 0;
            while (codigo < 1 || codigo > 13)
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

            if (alunos.Count == 0)
            {
                Console.WriteLine("Não foi cadastrado nenhum alunos até o momento");
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

        private void ObterAlunoPorCodigo()
        {
            ObterTodosAlunos();

            Console.WriteLine("Informe o código de matrícula do aluno que deseja ver o cadastro: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            var alunoSelecionado = alunoServico.ObterAlunoPorCodigo(codigoMatricula);

            if (alunoSelecionado == null)
            {
                Console.WriteLine("Aluno não cadastrado até o momento");
                return;
            }
            Console.Clear();
            Console.WriteLine($@"
Nome do aluno: {alunoSelecionado.Nome}
Código de matrícula do aluno: {alunoSelecionado.CodigoMatricula}
Idade do aluno: {alunoSelecionado.Idade}
Matéria favorita do aluno: {alunoSelecionado.MateriaFavorita}
Primeira nota do aluno: {alunoSelecionado.Nota1}
Segunda nota do aluno: {alunoSelecionado.Nota2}
Terceira nota do aluno: {alunoSelecionado.Nota3}" + "\n");
            Console.WriteLine();
        }

        public void ApresentarMediaNotas()
        {
            Console.WriteLine($"A média das notas dos alunos é: {alunoServico.ObterMediasNotas()}");
        }


        private void ListarAprovados()
        {
            var nomesAprovados = "";
            var alunos = alunoServico.ObterAprovados();

            for (var i = 0; i < alunos.Count; i++)
            {
                nomesAprovados += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos aprovados é: {nomesAprovados}");
        }
    }
}
