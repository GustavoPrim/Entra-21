namespace Entra21.ExercicioListasObjetos.Exercício01
{
    internal class TrianguloController
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

                if (codigo == 1)
                    Cadastrar();

                else if (codigo == 2)
                    Editar();

                else if (codigo == 3)
                    Apagar();

                else if (codigo == 4)
                    ApresentarTriangulo();

                else if (codigo == 5)
                    ApresentarTodos();

                Console.WriteLine("\n\nAperte alguma tecla para continuar");
                Console.ReadKey();
            }
        } //V

        private void Cadastrar()
        {
            Console.Write("Informe o primeiro lado do triângulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo lado do triângulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o terceiro lado do triângulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);
        } //V

        private int Menu()
        {
            Console.WriteLine($@"  MENU
01 - Cadastrar
02 - Editar
03 - Apagar
04 - Apresentar triângulo
05 - Apresentar Triângulos
06 - Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        } //V

        private int SolicitarCodigo()
        {
            var codigo = 0;
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Informe o menu desejado: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Código informado é inválido, informe o código novamente.");
                }
            }
            return codigo;
        } //V

        private void Editar()
        {
            ApresentarTodos();

            Console.Write("Código do triângulo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o primeiro lado do triângulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo lado do triângulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o terceiro lado do triângulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var alterado = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if (alterado == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("Triângulo cadastrado com sucesso");
            }
        } //V

        private void ApresentarTriangulo()
        {
            ApresentarTodos();

            Console.Write("Informe o código do triângulo que deseja ver: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var trianguloSelecionado = trianguloServico.ObterPorCodigo(codigo);

            if (trianguloSelecionado == null)
            {
                Console.WriteLine("Triângulo não existe");
                return;
            }

            Console.Clear();
            Console.WriteLine($@"
Código: {trianguloSelecionado.Codigo}
Primeiro lado do triângulo: {trianguloSelecionado.Lado1}
Segundo lado do triângulo: {trianguloSelecionado.Lado2}
Terceiro lado do triângulo: {trianguloSelecionado.Lado3}");
        } //V

        private void ApresentarTodos()
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
Terceiro lado do triângulo: {trianguloAtual.Lado3}" + "\n");
                Console.WriteLine();
            }
        } //V

        private void Apagar()
        {
            ApresentarTodos();

            Console.Write("Informe o código do produto para apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var codigoApagado = trianguloServico.Apagar(codigo);

            Console.WriteLine(codigoApagado == true
                ? "Triângulo removido com sucesso"
                : "Nenhum triângulo cadastrado com esse código");
        } //V
    }
}
