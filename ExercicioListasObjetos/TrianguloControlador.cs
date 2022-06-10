namespace Entra21.ExercicioListasObjetos
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;
            while (codigo != 6)
            {
                Console.Clear();

                codigo = Menu();

                Console.Clear();

                //if (codigo == 1)
                //    Cadastrar();

                else if (codigo == 2)
                    Editar();

                else if (codigo == 3)
                    Apagar();

                //else if (codigo == 4)
                //ApresentarTriangulo();

                else if (codigo == 5)
                    ApresentarTriangulos();
            }
        }

        private void Cadastrar()
        {
            Console.Write("Informe o primeiro lado do triângulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo lado do triângulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o terceiro lado do triângulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);
        }

        private int Menu()
        {
            Console.WriteLine($@"
01 - Cadastrar
02 - Editar
03 - Apagar
04 - Apresentar triângulo
05 - Apresentar Triângulos
06 - Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        }

        private int SolicitarCodigo()
        {
            var codigo = 0;
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Código informado não existe, informe o código novamente: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Código informado é inválido, informe o código novamente.");
                }
            }
            return codigo;
        }

        private void Editar()
        {
            ApresentarTriangulos();

            Console.WriteLine("Código de triângulo desejado: ");
            var codigoDesejado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Lado1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Lado2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Lado3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var trianguloEditado = trianguloServico.Editar(lado1, lado2, lado3, codigoDesejado);
            if (trianguloEditado == false)
                Console.WriteLine("Código digitado não existe");

            else
                Console.WriteLine("Triângulo cadastrado com sucesso");
        }

        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triângulo cadastrado ainda");
                return;
            }

            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($@"
Código: {trianguloAtual.Codigo}
Primeiro lado do triângulo: {trianguloAtual.Lado1}
Segundo lado do triângulo: {trianguloAtual.Lado2}
Terceiro lado do triângulo: {trianguloAtual.Lado3}");
            }
        }
        private void Apagar()
        {
            ApresentarTriangulos();

            Console.Write("Informe o código do produto para apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var codigoApagado = trianguloServico.Apagar(codigo);

            Console.WriteLine(codigoApagado == true
                ? "Código apagado com sucesso"
                : "Nenhum triângulo cadastrado com esse código");
        }
    }
}
