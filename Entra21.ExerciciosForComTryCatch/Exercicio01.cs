using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio01
    { public void Executar()
        {
            var nomePeca = "";
            var precoPeca = 0.0;
            for (var i = 0; i < 13; i++)
            {
                while (nomePeca.Length < 6)
                {
                    Console.Write("Informe o nome da peça: ");
                    nomePeca = Console.ReadLine();
                    Console.WriteLine();
                }
                Console.Write("Informe o valor da peça: ");
                precoPeca = Convert.ToDouble(Console.ReadLine());
            }
        }
        
    }
}
