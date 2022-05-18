using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio01
    {
        public void Executar()
        {
            var valorValido = false;
            var valorTotal = 0;
            var informacao = "";
            for (var i = 0; i < 13; i++)
            {
                Console.Write("Informe o nome da peça: ");
                var nomePeca = Console.ReadLine();

                valorValido = false;

                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Informe o valor da peça: ");
                        var precoPeca = Convert.ToDouble(Console.ReadLine());
                        if (precoPeca < 0)
                        {
                            valorValido = false;
                            Console.WriteLine("O valor da peça não pode ser negativo.");
                        }
                        else
                        {
                            valorValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor não é valido.");
                    }
                }

            }
        }

    }
}
