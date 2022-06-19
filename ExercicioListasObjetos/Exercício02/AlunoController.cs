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

                if (codigo == 1)
                    AdicionarAluno();

                else if (codigo == 2)
                    RemoverAluno();

                else if (codigo == 3)
                    EditarDadosCadastrais();

                else if (codigo == 4)
                    EditarNotasAlunos();

                else if (codigo == 5)
                    ObterNomes();

                else if (codigo == 6)
                    ObterTodosAlunos();

                else if (codigo == 7)
                    ObterAlunoPorCodigo();

                else if (codigo == 8)
                    ObterMediaPorCodigo();

                else if (codigo == 9)
                    ListarAprovados();

                else if (codigo == 10)
                    ListarReprovados();

                else if (codigo == 11)
                    ListarEmExame();

                else if (codigo == 12)
                    ObterMediaIdades();

                else if (codigo == 13)
                    ObterStatusPorCodigo();


                Console.WriteLine("\n\nAperte alguma tecla para continuar");
                Console.ReadKey();
            }
        } //V

        private void RemoverAluno()
        {
            ObterTodosAlunos();

            Console.WriteLine("Informe o nome do aluno que deseja remover o cadastro: ");
            var nomeAluno = Console.ReadLine();

            var nomeApagado = alunoServico.RemoverAluno(nomeAluno);

            Console.WriteLine(nomeApagado == true
                ? "Cadastro do aluno removido com sucesso"
                : "Nenhum aluno como esse código de matrícula cadastrado");
        } //V

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
        } //V

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
        } //V

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
        } //V

        private int Menu()
        {
            Console.WriteLine(@"   MENU
01 - ADICIONAR ALUNO
02 - REMOVER ALUNO
03 - EDITAR DADOS CADASTRAIS DO ALUNO
04 - EDITAR NOTAS DOS ALUNOS
05 - OBTER ALUNO POR NOME
06 - OBTER TODOS OS ALUNOS
07 - OBTER ALUNO POR CÓDIGO
08 - OBTER A MEDIA DA NOTA DOS ALUNOS POR CÓDIGO
09 - OBTER OS ALUNOS APROVADOS
10 - OBTER OS ALUNOS REPROVADOS
11 - OBTER OS ALUNOS EM EXAME
12 - OBTER A MÉDIA DAS IDADES DOS ALUNOS
13 - OBTER STATUS DO ALUNO POR CÓDIGO DE MATRÍCULA
14 - Sair");

            var codigo = SolicitarCodigo();
            return codigo;
        } //V

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
        } //V

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
        } //V

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
        } //V

        public void ObterNomes()
        {
            var nomes = alunoServico.ObterNomesAlunos();

            if (nomes != null)
            {
                for (var i = 0; i < nomes.Count; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
                return;
            }
            Console.WriteLine("Nnehum aluno cadastrado ainda");
        } //V

        private void ListarAprovados()
        {
            var nomesAprovados = "";
            var alunos = alunoServico.ObterAprovados();

            for (var i = 0; i < alunos.Count; i++)
            {
                nomesAprovados += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos aprovados é: {nomesAprovados}");
        } //V

        private void ListarReprovados()
        {
            var nomesReprovados = "";
            var alunos = alunoServico.ObterReprovados();

            for (var i = 0; i < alunos.Count; i++)
            {
                nomesReprovados += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos reprovados é: {nomesReprovados}");
        } //V

        private void ListarEmExame()
        {
            var nomesEmExame = "";
            var alunos = alunoServico.ObterEmExame();

            for (var i = 0; i < alunos.Count; i++)
            {
                nomesEmExame += alunos[i] + " | ";
            }
            Console.WriteLine($"O nome dos alunos em exame é: {nomesEmExame}");
        } //V

        private void ObterMediaIdades()
        {
            Console.WriteLine($"A média de idade dos alunos é: {alunoServico.ObterMediaIdades()}");
        } //V

        private void ObterMediaPorCodigo()
        {
            ObterTodosAlunos();

            Console.Write("Digite o código da matrícula do aluno que deseja ver a média: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A média do aluno é: {alunoServico.ObterMediaPorCodigoMatricula(codigo)}");
        } //V

        private void ObterStatusPorCodigo()
        {
            ObterTodosAlunos();

            Console.WriteLine("Digite o código do aluno que deseja saber o status: ");
            var status = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O status do aluno é: {alunoServico.ObterStatusPorCodigoMatricula(status)}");
        } //V
    }
}
