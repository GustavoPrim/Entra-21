using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacoesObjetos.Exercicio01
{
    public class ExercicioLivro
    {
        public void Executar()
        {
            var livro = new Livro();

            livro.Titulo = "O Pequeno Príncipe";
            livro.Autor = "Antoine de Saint-Exupéry";
            livro.IdiomaOriginal = "Francês";
            livro.Isbn = "8595081514";
            livro.DataLancamento = new DateTime(2018, 08, 27);
            livro.QuantidadePaginas = 96;
            livro.QuantidadePaginasLidas = 68;
            livro.QuantidadeReleituras = 5;

            livro.ApresentarTituloAutor();
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadePaginasLidasNoTotal();
            livro.ApresentarQuantidadeAnosAposPublicacao();
        }
    }
}
