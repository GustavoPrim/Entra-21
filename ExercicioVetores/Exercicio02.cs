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
                var nomeValido = false;
                while (nomeValido == false)
                {
                    Console.Write("Informe um nome: ");
                    nomes[i] = Console.ReadLine();
                    if (nomes[i].Length < 3 || nomes[i].Length > 15)
                    {
                        Console.WriteLine("O nome deve conter no máximo 15 e no mínimo 3 caracteres.");
                    }
                    else
                    {
                        nomeValido = true;
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < 10; i = i + 1)
            {
                Console.WriteLine("Nomes Informados: " + nomes[i]);
            }
        }
    }
}
