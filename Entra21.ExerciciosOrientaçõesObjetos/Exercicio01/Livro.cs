using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacoesObjetos.Exercicio01
{
    public class Livro
    {
        public string DataLancamento, Isbn, Titulo, Autor;
        public int QuantidadePaginas, QuantidadePaginasLidas, QuantidadeReleituras;
        public string IdiomaOriginal;

        public string ApresentarTituloAutor()
        {
            var titulo = Titulo;
            var autor = Autor;
            Console.WriteLine("Título do livro: " + titulo);
            Console.WriteLine("Autor do livro: " + autor);

            return titulo;
            return autor;
        }

        public int ApresentarQuantidadePaginasParaLer()
        {
            var paginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;
            Console.WriteLine("Págiinas que faltam para ler: " + paginasParaLer);

            return paginasParaLer;
        }

        public int ApresentarQuantidadePaginasLidasNoTotal()
        {
            var paginasLidasTotal = QuantidadePaginas * QuantidadeReleituras + QuantidadePaginasLidas;
            Console.WriteLine("Páginas lidas no total: " + paginasLidasTotal);

            return paginasLidasTotal;
        }
    }
}
