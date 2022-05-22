using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio03
    {
        public void Executar()
        {
            string[] nomesProdutos = new string[7];
            double[] valorProdutos = new double[7];
            for (int i = 0; i < 7; i = i + 1)
            {
                Console.Write("Informe o nome do produto: ");
                nomesProdutos[i] = Console.ReadLine();
                bool valorValido = false;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Informe o valor do produto:R$ ");
                        valorProdutos[i] = Convert.ToDouble(Console.ReadLine());
                        if (valorProdutos[i] < 0)
                        {
                            Console.WriteLine("Valor do produto não pode ser negativo, informe o valor novamente.");
                        }
                        else
                        {
                            valorValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor digitado não é válido, informe o valor novamente.");
                    }

                }
            }
            Console.Clear();
            for (int i = 0; i < 7; i = i + 1)
            {
                Console.WriteLine("Nome do produto: " + nomesProdutos[i] + "     " + "Valor do produto:R$ " + valorProdutos[i]);
            }
        }
    }
}
