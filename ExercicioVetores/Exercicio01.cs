using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[10];
            bool numeroValido = false;
            for (int i = 0; i < 16; i = i + 1)
            {
                while (numeroValido == false)
                {
                    numeroValido = false;
                    try
                    {
                        Console.Write("Informe um número inteiro: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        numeroValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Número digitado não é válido, informe novamente.");
                    }
                }
                Console.Clear();
            }
            int mediaNumeros = 0;
            int somaNumeros = 0;
            for (int i = 0; i < 16; i = i + 1)
            {
                somaNumeros = somaNumeros + numeros[i];
                mediaNumeros = somaNumeros / 16;
            }
            Console.Clear();
            Console.WriteLine("Média dos números: " + mediaNumeros);
        }
    }
}
