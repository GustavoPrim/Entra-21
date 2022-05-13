using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio09
    {
        public void Executar()
        {
            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int indice = numero - 1;
            int fatorial = numero;

            while (indice > 1)
            {
                fatorial = fatorial * indice;
                indice = indice - 1;
            }
            Console.WriteLine(fatorial);
        }
    }
}
