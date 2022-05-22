using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio07
    {
        public void Executar()
        {
            double[] altura = new double[4];
            bool alturaValida = false;
            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write("Nome do animal: ");
                string nomeAnimal = Console.ReadLine();
                try
                {
                    alturaValida = false;
                    while (alturaValida == false)
                    {
                        Console.Write("Altura do animal: ");
                        altura[i] = Convert.ToDouble(Console.ReadLine());
                        if (altura[i] <= 0)
                        {
                            Console.WriteLine("Altura do animal não pode ser menor ou igual a zero, informe a altura novamente.");
                        }
                        else
                        {
                            alturaValida = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Altura digitada não é válida, informe a altura novamente.");
                }
            }
            Console.Clear();
            double menorAltura = double.MaxValue;
            for (int i = 0; i < altura.Length; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine("Menor altura: " + menorAltura);
        }
    }
}




