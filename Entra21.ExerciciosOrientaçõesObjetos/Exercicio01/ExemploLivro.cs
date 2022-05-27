using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacoesObjetos.Exercicio01
{
    public class ExemploLivro
    {
        Livro livro = new Livro();
        public void SolicitarInformacoesLivro()
        {
            Console.Write("Informe o título do livro: ");
            livro.Titulo = Console.ReadLine();
            Console.Write("Informe o autor do livro: ");
            livro.Autor = Console.ReadLine();
            Console.Write("Informe o código ISBN(somente os números do código): ");
            livro.Isbn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Data de lançamento do livro: ");
            livro.DataLancamento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas do livro: ");
            livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas lidas: ");
            livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas relidas: ");
            livro.QuantidadeReleituras = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Título e autor do livro: " + livro.ApresentarTituloAutor +
                            "\nQuantidade de páginas para ler: " + livro.ApresentarQuantidadePaginasParaLer +
                            "\nQuantidade de páginas lidas no total: " + livro.ApresentarQuantidadePaginasLidasNoTotal);


        }
    }
}
