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
            for(int i = 0; i < numerosPrimeiroVetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                numerosPrimeiroVetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
