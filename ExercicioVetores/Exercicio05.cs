using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
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
