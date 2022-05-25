using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio11
    {
        public void Executar()
        {
            var numeros = new int[10];
            for (var i = 0; i < numeros.Length; i++)
            {
                var numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe um número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        if (numeros[i] < 0)
                        {
                            Console.WriteLine("Número deve ser maior que zero, informe um número novamente.");
                        }
                        else
                        {
                            numeroValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Número digitado não é válido, informe um número novamente.");
                    }
                }
            }
            var pares = new int[10];
            var impares = new int[10];
            for (var i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];
                }
                else
                {
                    impares[i] = numeros[i];
                }
            }
            Console.Clear();
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Números pares apresentados: " + pares[i] + "           " + "Números ímpares apresentados: " + impares[i]);
            }
        }
    }
}

