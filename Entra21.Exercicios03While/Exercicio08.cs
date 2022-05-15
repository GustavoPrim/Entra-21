using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.Write("Informe um número: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());
            int tabuada = 0;

            while (tabuada <= 1000)
            {
                int total = numeroTabuada * tabuada;
                Console.WriteLine(numeroTabuada + " * " + tabuada + " = " + total);
                tabuada = tabuada + 1;
            }
        }
    }
}