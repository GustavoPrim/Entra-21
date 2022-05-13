using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            string sucessores = "";
            string antecessores = "";
            int numeroAntecessores = numero;
            int numeroSucessores = numero;

            while (indice < 100)
            {
                numeroAntecessores = numeroAntecessores - 1;
                numeroSucessores = numeroSucessores + 1;

                if (numeroAntecessores % 2 == 0)
                {
                    antecessores = antecessores + numeroAntecessores + ", ";
                }
                if (numeroSucessores % 2 == 1)
                {
                    sucessores = sucessores + numeroSucessores + ", ";
                }
                indice = indice + 1;
            }
            Console.WriteLine("Números antecessores pares: " + antecessores);
            Console.WriteLine("Números sucessores ímpares: " + sucessores);
        }
    }
}
