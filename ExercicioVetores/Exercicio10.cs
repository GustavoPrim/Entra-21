using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio10
    {
        public void Executar()
        {
            var numerosPrimeiroVetor = new int[6];
            var numerosSegundoVetor = new int[6];
            for (var i = 0; i < numerosPrimeiroVetor.Length; i++)
            {
                var numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Digite um número: ");
                        numerosPrimeiroVetor[i] = Convert.ToInt32(Console.ReadLine());
                        numeroValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Número digitado não é válido, informe o número novamente.");
                    }
                }
            }
            for (var i = 0; i < numerosSegundoVetor.Length; i++)
            {
                if (i == 0)
                {
                    numerosSegundoVetor[i] = numerosPrimeiroVetor[numerosSegundoVetor.Length - 1] + numerosPrimeiroVetor[i];
                }
                else
                {
                    numerosSegundoVetor[i] = numerosPrimeiroVetor[i - 1] + numerosPrimeiroVetor[i];
                }
                Console.WriteLine("Numeros primeiro vetor: " + numerosPrimeiroVetor[i] + "          " + "Numeros segundo vetor: " + numerosSegundoVetor[i]);
            }
        }
    }
}
