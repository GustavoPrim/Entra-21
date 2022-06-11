namespace Entra21.ExercicioListasObjetos.Exercício01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 1;

        public void Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            triangulo.Codigo = codigoAtual;
            codigoAtual = codigoAtual + 1;
            triangulos.Add(triangulo);
        } //V

        public bool Editar(int codigoAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloEditar = ObterPorCodigo(codigoAlterar);

            if (trianguloEditar == null)
                return false;

            trianguloEditar.Lado1 = lado1;
            trianguloEditar.Lado2 = lado2;
            trianguloEditar.Lado3 = lado3;

            return true;
        } //V

        public bool Apagar(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[i];
                if (triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);

                    return true;
                }
            }
            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloSelecionado = triangulos[i];

                if (trianguloSelecionado.Codigo == codigo)
                    return trianguloSelecionado;
            }
            return null;
        }
    }
}
