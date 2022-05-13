using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.Write("Quantidade de carros: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            int indice = 0;
            int valorCarro = 0;
            int anoCarros = 0;
            int somaValorCarros = 0;
            int somaAnoCarros = 0;
            string modeloCarros = "";
            int quantidadeCarrosLetraA = 0;
            int quantidadeCarrosLetraG = 0;
            int quantidadeCarrosOutros = 0;

            while (indice < quantidadeCarros)
            {

                Console.Write("Modelo do carros: ");
                modeloCarros = Convert.ToString(Console.ReadLine());

                Console.Write("Valor do carro: ");
                valorCarro = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ano do carro: ");
                anoCarros = Convert.ToInt32(Console.ReadLine());

                if (modeloCarros.ToLower().Trim().StartsWith("a"))
                {
                    quantidadeCarrosLetraA = quantidadeCarrosLetraA + 1;
                }
                else if (modeloCarros.ToLower().Trim().StartsWith("g"))
                {
                    quantidadeCarrosLetraG = quantidadeCarrosLetraG + 1;
                }
                else
                {
                    quantidadeCarrosOutros = quantidadeCarrosOutros + 1;
                }

                indice = indice + 1;
                somaValorCarros = somaValorCarros + valorCarro;
                somaAnoCarros = somaAnoCarros + anoCarros;

            }
            double mediaAnoCarros = somaAnoCarros / quantidadeCarros;
            double mediaValorCarros = somaValorCarros / quantidadeCarros;

            Console.Clear();

            Console.WriteLine("Média dos anos dos carros é: " + mediaAnoCarros);
            Console.WriteLine("Média do valor dos carros é: " + mediaValorCarros);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + quantidadeCarrosLetraA);
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + quantidadeCarrosLetraG);
        }
    }
}