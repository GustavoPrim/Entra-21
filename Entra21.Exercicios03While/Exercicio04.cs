using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double pesoUsuario = 0;
            string infomacao = "";
            int indice = 0;
            while ((pesoUsuario >= 0) && (pesoUsuario < 300))
            {
                Console.Write("Informar o peso: ");
                pesoUsuario = Convert.ToDouble(Console.ReadLine());

                infomacao = infomacao + "Peso " + pesoUsuario + "\n";
                indice = indice + 1;
                Console.Clear();
            }
            Console.WriteLine("Peso dos usuários: " +
               "\n" + infomacao);
        }
    }
}