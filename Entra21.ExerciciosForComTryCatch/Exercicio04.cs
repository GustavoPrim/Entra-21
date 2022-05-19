using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio04
    {
        public void Executar()
        {
            var antecessoresFinal = "";
            var sucessoresFinal = "";
            var numero = 0;
            var numeroValido = false;

            while (numeroValido == false)
            {
                try
                {
                    Console.Write("Informe um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    numeroValido = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O valor não é válido");
                }
            }

            var antecessores = numero;
            var sucessores = numero;

            for (var i = 0; i <= 100; i++)
            {
                antecessores--;
                sucessores++;
                if (antecessores % 2 == 0)
                {
                    antecessoresFinal = antecessoresFinal + antecessores + ", ";
                }
                else if (sucessores % 2 != 0)
                {
                    sucessoresFinal = sucessoresFinal + sucessores + ", ";
                }
            }

            Console.WriteLine("Os sucessores ímpares são: " + sucessoresFinal);
            Console.WriteLine("Os antecessores pares são: " + antecessoresFinal);
        }
    }
}