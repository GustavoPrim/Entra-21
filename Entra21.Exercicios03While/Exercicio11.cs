using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int opcaoEscolhida = 0;

            Console.Write("Digite um número: ");
            double primeiroNumeroUsuario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double segundoNumeroUsuario = Convert.ToDouble(Console.ReadLine());

            while (opcaoEscolhida != 5)
            {
                Console.WriteLine(@"----------MENU---------------------------
|1                        | Somar        |
|2                        | Subtrair     |
|3                        | Multiplicar  |
|4                        | Dividir      |
|5                        | Sair         |
-----------------------------------------");

                Console.Write("Escolha uma opção: ");
                opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

                if (opcaoEscolhida == 1)
                {
                    Console.WriteLine(primeiroNumeroUsuario + " + " + segundoNumeroUsuario + " = " + (primeiroNumeroUsuario + segundoNumeroUsuario));
                }
            }
        }
    }
}
