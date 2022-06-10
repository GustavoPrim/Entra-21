﻿namespace Entra21.ExemplosListas
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            // Repete enquanto o código não for o menu sair(6)
            while (codigo != 6)
            {
                Console.Clear();

                // Apresenta o menu e solicita o código
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    // Menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    // Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    // Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    // Menu escolhido para apagar produto
                    Apagar();
                }
                else if (codigo == 5)
                {
                    // Menu escolhido para apresentar produto
                    ApresentarProduto();
                }
                Console.WriteLine("\n\nAperte alguma tecla para continuar");
                Console.ReadKey();
            }
        }

        private void ApresentarProduto()
        {
            ApresentarProdutos();

            Console.Write("Digite o código do produto a ser detalhado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            // Verifica se o produto não está cadastrado na lista de produtos
            if (produto == null)
            {
                Console.WriteLine("Produto não cadastrado");

                return;
            }

            Console.Clear();
            Console.WriteLine($@"Código: {produto.Codigo}
Nome: {produto.Nome}
Preço Unitário: {produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: {produto.CalcularPrecoTotal()}");
        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"  MENU      
01 - Listar todos
02 - Cadastrar
03 - Editar
04 - Apagar
05 - Apresentar produto desejado
06 - Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;
            // Continua solicitando o código até que seja um código entre 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }
            return codigo;
        }

        private void Editar()
        {
            ApresentarProdutos();

            Console.Write("Código produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponíveis: 
- Armazém
- Área Venda
- Loja");

            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }
        }

        private void Apagar()
        {
            ApresentarProdutos();

            Console.Write("Digite o código do produto para apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com o código informado"); ;
        }

        private void Cadastrar()
        {
            Console.Write("Informe o nome do produto: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a quantidade do produto: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o preço unitário do produto: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponíveis: 
- Armazém
- Área Venda
- Loja");

            Console.Write("Informe a localização do produto informado: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
                return ProdutoLocalizacao.Armazem;

            else if (localizacao.ToLower() == "loja")
                return ProdutoLocalizacao.Loja;

            else
                return ProdutoLocalizacao.AreaVenda;
        }

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado :( ");
                // Para a execução deste método
                return;
            }

            Console.WriteLine("Lista de produtos");

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.Write(
                    "Código: " + produtoAtual.Codigo +
                    "\nNome: " + produtoAtual.Nome + "\n");
                Console.WriteLine();
            }
        }
    }
}