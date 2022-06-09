namespace Entra21.ExemplosListas
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            Cadastrar();
            ApresentarProdutos();
            Cadastrar();
            ApresentarProdutos();
        }

        private void Cadastrar()
        {
            Console.Write("Informe o nome do produto: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a quantidade do produto: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o preço unitário do produto: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

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

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.Write("Nome: " + produtoAtual.Nome +
                          "\nPreço unitário: " + produtoAtual.PrecoUnitario);
                Console.WriteLine();
            }
        }
    }
}