using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Entra21.ExerciciosListas
{
    public class Exercicio01
    {
        public void Executar()
        {
            List<string> melhoresFilmes = new List<string>();
            melhoresFilmes.Add("Dragon Ball Evollution");
            melhoresFilmes.Add("Titanic");
            melhoresFilmes.Add("Lanterna Verde");
            Console.WriteLine("Melhores filmes: " +
                                             "\n" + melhoresFilmes[0] +
                                             "\n" + melhoresFilmes[1] +
                                             "\n" + melhoresFilmes[2]);

            //Alterar o filme
            melhoresFilmes[0] = "Dragon Ball Super: Broly";
            
            //Remover o filme
            melhoresFilmes.Remove("Lanterna Verde");

            //Contém o filme cadastrado ou não
            var contemLanternaVerde = melhoresFilmes.Contains("Lanterna Verde");

            Console.WriteLine();
            Console.WriteLine();

            if (contemLanternaVerde == false)
                Console.WriteLine("Não contém o filme Lanterna Verde");

            else
                Console.WriteLine("Contém o filme Lanterna Verde");

            melhoresFilmes.Add("Quarteto Fantástico");
            
            Console.WriteLine("Melhores filmes: " +
                                             "\n" + melhoresFilmes[0] + 
                                             "\n" + melhoresFilmes[1] +
                                             "\n" + melhoresFilmes[2]);

            Console.WriteLine();
            Console.WriteLine();

            melhoresFilmes[1] = "Titanic 2";

            Console.WriteLine("Melhores filmes: " +
                                             "\n" + melhoresFilmes[0] +
                                             "\n" + melhoresFilmes[1] +
                                             "\n" + melhoresFilmes[2]);


            var contemLagoaAzul = melhoresFilmes.Contains("A Lagoa Azul");

            if (contemLagoaAzul == false)
                Console.WriteLine("Não contém o filme A Lagoa Azul");

            else
                Console.WriteLine("Contém o filme A Lagoa Azul");
        }
        
    }
}
