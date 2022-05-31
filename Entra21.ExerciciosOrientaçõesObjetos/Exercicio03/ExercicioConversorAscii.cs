using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacoesObjetos.Exercicio03
{
    public class ExercicioConversorAscii
    {
        public void Executar()
        {
            var conversor = new ConversorAscii();
            Console.Write("Informe a letra que você deseja descobrir o código ascii: ");
            conversor.Caracter = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"O código ascii de {conversor.Caracter} é {conversor.ObterCodigoAsciiCaracter()}");

        }
    }
}
