using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio04
    {
        public void Executar()
        {

            double[] notas = new double[4];


            Console.Write("Informe a matéria: ");
            string materia = Console.ReadLine();
            bool notaValida = false;

            for (int i = 0; i < notas.Length; i++)
            {
                notaValida = false;
                while (notaValida == false)
                {
                    try
                    {
                        Console.Write("Nota: ");
                        notas[i] = Convert.ToDouble(Console.ReadLine());
                        if (notas[i] < 0)
                        {
                            Console.WriteLine("A nota não pode ser negativa, informe a nota novamente");
                        }
                        else
                        {
                            notaValida = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nota digitada não é válida, informe a nota novamente.");
                    }
                }
            }
            double somaNotas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                somaNotas = somaNotas + notas[i];
            }
            double mediaNotas = somaNotas / notas.Length;

            Console.Clear();

            Console.WriteLine("Matéria escolhida: " + materia +
                                "\nMédia da matéria: " + mediaNotas);
        }
    }
}