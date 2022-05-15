using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio14
    {
        public void Executar()
        {
            Console.Write("Quantas caracteres serão utilizadas: ");
            int quantidadeCaracteres = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            string frase = "";
            while (indice < quantidadeCaracteres)
            {
                Console.Write("Caracteres: ");
                char caracteres = Convert.ToChar(Console.ReadLine());
                frase = caracteres;
                indice = indice + 1;
            }
            Console.WriteLine(frase);
        }
    }
}

