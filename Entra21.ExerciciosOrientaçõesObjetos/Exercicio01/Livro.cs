using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacoesObjetos.Exercicio01
{
    public class Livro
    {
        public string Titulo, Autor;
        public int DataLancamento, Isbn, QuantidadePaginas, QuantidadePaginasLidas, QuantidadeReleituras;
        public string IdiomaOriginal;

        public string ApresentarTituloAutor()
        {
            Console.WriteLine(Titulo);
            Console.WriteLine(Autor);
        }

        public int ApresentarQuantidadePaginasParaLer()
        {
            var paginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;
        }

        public int ApresentarQuantidadePaginasLidasNoTotal()
        {
            var paginasLidasTotal = QuantidadePaginasLidas;
        }
    }
}
