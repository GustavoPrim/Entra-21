using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio09
    {
        public void Executar()
        {
            var nomesPrimeiroVetor = new string[6];
            var nomesSegundoVetor = new string[6];
            for (var i = 0; i < nomesPrimeiroVetor.Length; i++)
            {
                var nomeValido = false;
                while(nomeValido == false)
                {
                    Console.Write("Informe um nome: ");
                    nomesPrimeiroVetor[i] = Console.ReadLine().ToLower().Trim();
                    if ((nomesPrimeiroVetor[i].Length < 3) || (nomesPrimeiroVetor[i].Length > 14))
                    {
                        Console.WriteLine("Nome deve conter no mínimo 3 caracteres e no máximo 14, digite um nome novamente.");
                    }
                    else
                    {
                        nomeValido = true;
                    }
                }
                Console.Clear();
            }
            for (int i = 0; i < nomesPrimeiroVetor.Length; i++)
            {
                nomesSegundoVetor[i] = nomesPrimeiroVetor[(nomesSegundoVetor.Length - i - 1)];
                Console.WriteLine("Primeiro vetor: " + nomesPrimeiroVetor[i] + "         " + "Segundo vetor: " + nomesSegundoVetor[i]);
            }
        }
    }
}


