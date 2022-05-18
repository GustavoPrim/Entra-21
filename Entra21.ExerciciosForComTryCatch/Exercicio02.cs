using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio02
    {
        public void Executar()
        {
            Console.Write("Informe a quantidade de carros: ");
            var quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            var modeloCarro = "";
            var totalAnoCarros = 0;
            var totalValorCarros = 0.0;
            var carrosComecaComG = 0;
            var carrosComecaComA = 0;
            var anoCarro = 0;
            var valorCarroValido = false;
            var anoCarroValido = false;

            for (var i = 0; i < quantidadeCarros; i++)
            {
                Console.Write("Informe o modelo do carro: ");
                modeloCarro = Console.ReadLine().Trim().ToLower();
                if (modeloCarro.StartsWith("g"))
                {
                    carrosComecaComG++;
                }
                if (modeloCarro.StartsWith("a"))
                {
                    carrosComecaComA++;
                }
                valorCarroValido = false;
                anoCarroValido = false;

                while (valorCarroValido == false)
                {
                    try
                    {
                        Console.Write("Informe o valor do carro: R$ ");
                        var valorCarro = Convert.ToDouble(Console.ReadLine());

                        if (valorCarro < 0)
                        {
                            Console.WriteLine("Valor do carro não pode ser negativo");
                        }
                        else
                        {
                            valorCarroValido = true;
                        }
                        totalValorCarros = totalValorCarros + valorCarro;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor digitado não é válido");
                    }
                }
                while (anoCarroValido == false)
                {
                    try
                    {
                        Console.Write("Informe o ano do carro: ");
                        anoCarro = Convert.ToInt32(Console.ReadLine());

                        if (anoCarro < 1870)
                        {
                            anoCarroValido = false;
                            Console.WriteLine("Ano digitado não é válido.");
                        }
                        else
                        {
                            anoCarroValido = true;
                        }

                        totalAnoCarros = totalAnoCarros + anoCarro;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ano informado não é válido");
                    }
                }
            }
            var mediaAnoCarros = totalAnoCarros / quantidadeCarros;
            var mediaValorCarros = totalValorCarros / quantidadeCarros;

            Console.WriteLine("Quantidade de carros cadastrados: " + quantidadeCarros +
                            "\nQuantidade de carros que começam com G: " + carrosComecaComG +
                            "\nQuantidade de carros que começam com A: " + carrosComecaComA +
                            "\n     " +
                            "\nMedia do valor dos carros é de:R$ " + mediaValorCarros +
                            "\nMedia do ano dos carros é de:R$ " + mediaAnoCarros);

        }
    }
}
