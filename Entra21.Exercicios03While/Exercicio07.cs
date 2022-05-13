using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio07
    {
        public void Executar()
        {
            string nomeProduto = "";
            double valorProduto = 0;
            int quantidadeProduto = 0;
            double valorTotal = 0;
            double valorComDesconto = 0;
            int indice = 0;

            while (quantidadeProduto < 5)
            {
                Console.Write("Nome do produto: ");
                nomeProduto = Convert.ToString(Console.ReadLine());

                Console.Write("Valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de produtos: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());


                indice = indice + 1;
                valorTotal = valorTotal + (valorProduto * quantidadeProduto);

            }
            valorComDesconto = valorTotal - 150;
            Console.WriteLine("Valor com desconto:R$ " + valorComDesconto);
            Console.WriteLine("Valor sem desconto:R$ " + valorTotal);
        }
    }
}