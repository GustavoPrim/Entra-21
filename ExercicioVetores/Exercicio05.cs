using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];
            for (int i = 0; i < 5; i++)
            {
                var pesoValido = false;
                while (pesoValido == false)
                {
                    try
                    {
                        Console.Write("Informe o peso: ");
                        pesos[i] = Convert.ToDouble(Console.ReadLine());
                        if (pesos[i] < 0)
                        {
                            Console.WriteLine("O peso não pode ser negativo, informe o peso novamente");
                        }
                        else
                        {
                            pesoValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Peso informado não é válido, informe o peso novamente.");
                    }
                }
            }
            double somaPesos = 0.0;
            double mediaPesos = 0.0;
            for (int i = 0; i < 5; i++)
            {
                somaPesos = somaPesos + pesos[i];
                mediaPesos = somaPesos / 5.0;
            }
            Console.Clear();
            Console.WriteLine("Soma total dos pesos: " + somaPesos +
                            "\nMédia das notas: " + mediaPesos);
        }
    }
}