using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int indice = 0;
            int generoMasculino = 0, generoFeminino = 0, menorQuantidadeCartoesAmarelos = int.MaxValue,
                maiorQuantidadeCartoesAmarelos = int.MinValue, menorQuantidadeCartoesVermelhos = int.MaxValue,
                maiorQuantidadeCartoesVermelhos = int.MinValue, menorNomeCaracteres = int.MaxValue;

            double menorPeso = double.MaxValue, maiorPeso = double.MinValue, maiorAltura = double.MinValue;

            string jogadorMaiorQuantidadeCartoesAmarelos = "", jogadorMenorQuantidadeCartoesAmarelos = "",
                   jogadorMaiorQuantidadeCartoesVermelhos = "", jogadorMenorQuantidadeCartoesVermelhos = "",
                   jogadorMenorPeso = "", jogadorMaiorPeso = "", jogadorMaiorAltura = "", jogadorMaiorNome = "",
                   jogadorMenorNome = "", maiorNome = "", menorNome = "";

            while (indice < 3)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();
                Console.Write("Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de gols marcados: ");
                int quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões amarelos recebidos: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões vermelhos recebidos: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    jogadorMenorPeso = nome;
                }
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    jogadorMaiorAltura = nome;
                }
                if (nome.Length > jogadorMaiorNome.Length)
                {
                    jogadorMaiorNome = nome;
                    maiorNome = nome;
                }
                if (sexo.ToLower().Trim().StartsWith("f"))
                {
                    generoFeminino = generoFeminino + 1;
                }
                if (sexo.ToLower().Trim().StartsWith("m"))
                {
                    generoMasculino = generoMasculino + 1;
                }
                if (quantidadeCartoesAmarelos <= menorQuantidadeCartoesAmarelos)
                {
                    menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                    jogadorMenorQuantidadeCartoesAmarelos = nome;
                }
                if (nome.Length < menorNomeCaracteres)
                {
                    menorNomeCaracteres = nome.Length;
                    menorNome = nome;
                }
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    jogadorMaiorPeso = nome;
                }
                if (quantidadeCartoesVermelhos >= maiorQuantidadeCartoesVermelhos)
                {
                    maiorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                    jogadorMaiorQuantidadeCartoesVermelhos = nome;
                }
                if (quantidadeCartoesAmarelos >= maiorQuantidadeCartoesAmarelos)
                {
                    maiorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                    jogadorMaiorQuantidadeCartoesAmarelos = nome;
                }
                if (quantidadeCartoesVermelhos <= menorQuantidadeCartoesVermelhos)
                {
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                    jogadorMenorQuantidadeCartoesVermelhos = nome;
                }
                indice = indice + 1;

            }
            Console.WriteLine("Jogador com o menor peso: " + jogadorMenorPeso +
                             "\n Jogador com a maior altura: " + jogadorMaiorAltura +
                             "\n Jogador com o maior nome: " + jogadorMaiorNome +
                             "\n Quantidade do sexo feminino: " + generoFeminino +
                             "\n Quantidade do sexo masculino: " + generoMasculino +
                             "\n Jogador com a menor quantidade de cartões amarelos recebidos: " + jogadorMenorQuantidadeCartoesAmarelos +
                             "\n Jogador com o menor nome: " + menorNome +
                             "\n Jogador com o maior peso: " + jogadorMaiorPeso +
                             "\n Jogador com a maior quantidade de cartões vermelhos recebidos: " + jogadorMaiorQuantidadeCartoesVermelhos +
                             "\n Jogador com a maior quantidade de cartões amarelos recebidos: " + jogadorMaiorQuantidadeCartoesAmarelos +
                             "\n Jogador com a menor quantidade de cartões vermelhos recebidos: " + jogadorMenorQuantidadeCartoesVermelhos);
        }
    }
}
