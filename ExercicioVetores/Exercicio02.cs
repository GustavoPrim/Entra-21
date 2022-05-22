using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string[10];
            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.Write("Informe um nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i = 0; i < 10; i = i + 1)
            {
                Console.WriteLine("Nomes Informados: " + nomes[i]);
            }
        }
    }
}
