using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio15
    {
        public void Executar()
        {
            Console.Write("Informe o texto: ");
            string texto = Console.ReadLine();
            int indice = 0;
            while (indice < texto.Length)
            {
                Console.WriteLine(texto.Substring(indice, 1));
                indice = indice + 1;
            }
        }
    }
}
