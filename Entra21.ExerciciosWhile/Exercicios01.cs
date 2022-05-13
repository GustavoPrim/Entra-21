using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicios01
    {
        public void Executar()
        {
            int indice = 0;
            double valorPeca = 0;
            string nomePeca = "";
            string informacao = "";
            while (indice < 13)
            {
                Console.Write("Informe o nome da peça: ");
                nomePeca = Convert.ToString(Console.ReadLine());
                Console.Write("Informe o valor da peça: ");
                valorPeca = Convert.ToDouble(Console.ReadLine());

                informacao = informacao + "Nome da peça: " + nomePeca + "        " + "Valor da peça: " + valorPeca + "\n";
                indice = indice + 1;
            }
            Console.WriteLine(informacao);
        }
    }
}
