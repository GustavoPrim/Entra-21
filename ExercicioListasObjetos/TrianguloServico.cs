using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListasObjetos
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 1;

        public void Adicionar(int lado1, int lado2, int lado3, int codigo)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            triangulo.Codigo = codigoAtual;
            codigoAtual = codigoAtual + 1;
            triangulos.Add(triangulo);
        }

        public bool Editar(int codigoAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloEditar = ObterPorCodigo(codigoAlterar);
            
            if (trianguloEditar == null)
                return false;

            trianguloEditar.Lado1 = lado1;
            trianguloEditar.Lado2 = lado2;
            trianguloEditar.Lado3 = lado3;

            return true;
        }

        public void Apagar()
        {

        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                
            }
            return null;
        }
    }
}
