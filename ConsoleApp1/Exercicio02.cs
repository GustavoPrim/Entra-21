using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Entra21.ExerciciosListas
{
    public class Exercicio02
    {
        public void Executar()
        {
            List<string> conteudosPassados = new List<string>();
            conteudosPassados.Add("Como fazer um bolo");

            Console.WriteLine("Conteúdos passados: " + conteudosPassados[0]);

            Console.WriteLine();
            Console.WriteLine();

            //Alterar
            conteudosPassados[0] = "Algoritmos, onde vivem? Do que se alimentam?";

            conteudosPassados.Add("Variáveis");
            conteudosPassados.Add("Mais pra frente");
            conteudosPassados.Add( "If com E");
            conteudosPassados.Add("If com OU");
            conteudosPassados.Add("While");
            conteudosPassados.Add ("For");

            Console.WriteLine("Conteúdos passados: " + conteudosPassados[0] +
                                                "\n" + conteudosPassados[1] +
                                                "\n" + conteudosPassados[2] +
                                                "\n" + conteudosPassados[3] +
                                                "\n" + conteudosPassados[4] +
                                                "\n" + conteudosPassados[5] +
                                                "\n" + conteudosPassados[6]);
            
            conteudosPassados.Add("Vetor");
            conteudosPassados.Add("Vetor");

            conteudosPassados.Remove("Vetor");
            conteudosPassados.Remove("Vetor");

            conteudosPassados.Add("Vetor");
            conteudosPassados[7] = "Vetor com For um amor na minha vida";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Conteúdos passados: " + conteudosPassados[0] +
                                                "\n" + conteudosPassados[1] +
                                                "\n" + conteudosPassados[2] +
                                                "\n" + conteudosPassados[3] +
                                                "\n" + conteudosPassados[4] +
                                                "\n" + conteudosPassados[5] +
                                                "\n" + conteudosPassados[6] +
                                                "\n" + conteudosPassados[7]);

            conteudosPassados.Add("Classe propriedades e métodos");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Conteúdos passados: " + conteudosPassados[0] +
                                                "\n" + conteudosPassados[1] +
                                                "\n" + conteudosPassados[2] +
                                                "\n" + conteudosPassados[3] +
                                                "\n" + conteudosPassados[4] +
                                                "\n" + conteudosPassados[5] +
                                                "\n" + conteudosPassados[6] +
                                                "\n" + conteudosPassados[7] +
                                                "\n" + conteudosPassados[8]);
        }
    }
}