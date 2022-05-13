using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nomeProduto = "";
            double valorProduto = 0;
            double quantidadeProdutos = 0;
            double valorTotalCompra = 0;
            double valorComDesconto = 0;

            while (nomeProduto != "sair")
            {
                Console.Write("Nome do produto: ");
                nomeProduto = Convert.ToString(Console.ReadLine().ToLower().Trim());

                if (nomeProduto != "sair")
                {
                    Console.Write("Valor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Quantidade de produtos: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                    valorTotalCompra = valorTotalCompra + (valorProduto * quantidadeProdutos);
                }
            }
            valorComDesconto = valorTotalCompra - (valorTotalCompra * 0.05);
            Console.WriteLine("Valor final com desconto:R$ " + valorComDesconto);
            Console.WriteLine("Valor final sem desconto:R$ " + valorTotalCompra);
        }
    }
}