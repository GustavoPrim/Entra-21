using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio08
    {
        public void Executar()
        {
            var numeros = new int[10];
            var numeroValido = false;
            for(var i = 0; i < numeros.Length; i++)
            {
                numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe um número par: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        if (numeros[i] % 2 == 0)
                        {
                            numeroValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Número digitado é ímpar, digite um número par.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Número digitado não é válido, informe o número novamente.");
                    }
                }
            }
            for (var i = 0; i <numeros.Length; i++)
            {
                Console.WriteLine("Números pares informados: " + numeros[i]);
            }
        }
    }
}
