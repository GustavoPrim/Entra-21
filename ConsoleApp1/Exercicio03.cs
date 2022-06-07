using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Entra21.ExerciciosListas
{
    public class Exercicio03
    {
        public void Executar()
        {
            List<double> notas = new List<double>();

            Console.Write("Informe a primeira nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe a segunda nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe a terceira nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine($"Notas: |{notas[0]}|  |{notas[1]}|  |{notas[2]}|");

            var totalNotas = notas[0] + notas[1] + notas[2];
            var mediaNotas = totalNotas / notas.Count;

            Console.WriteLine($"Média das notas é {mediaNotas}");

            if (mediaNotas < 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADO");
            }
            else if (mediaNotas >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROVADO");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
