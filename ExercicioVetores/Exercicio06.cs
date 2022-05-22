using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio06
    {
        public void Executar()
        {
            int[] idade = new int[9];
            bool idadeValida = false;
            for (int i = 0; i < idade.Length; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                try
                {
                    idadeValida = false;
                    while (idadeValida == false)
                    {
                        Console.Write("Informe uma idade: ");
                        idade[i] = Convert.ToInt32(Console.ReadLine());
                        if (idade[i] < 0)
                        {
                            Console.WriteLine("Idade não pode ser negativa, informe a idade novamente.");
                        }
                        else
                        {
                            idadeValida = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Idade informada é inválida, informe a idade novamente.");
                }
            }
            Console.Clear();
            int maiorIdade = int.MinValue;
            for (int i = 0; i < idade.Length; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                }
            }
            Console.WriteLine("Maior idade: " + maiorIdade);
        }
    }
}
