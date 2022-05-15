using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio12
    {
        public void Executar()
        {
            Console.WriteLine(@"                                       MENU                                      
==================================================================================|
|   Código   |     Tipo     |                    Nome                  |  Valor   |
==================================================================================|
|     01     |     Bolos    |               Bolo Brigadeiro            | R$ 29,50 |
==================================================================================|
|     02     |     Bolos    |             Bolo Floresta Negra          | R$ 02,00 |
==================================================================================|
|     03     |     Bolos    |            Bolo Leite com Nutella        | R$ 29,23 |
==================================================================================|
|     04     |     Bolos    |           Bolo Mousse de Chocolate       | R$ 07,10 |
==================================================================================|
|     05     |     Bolos    |               Bolo Nega Maluca           | R$ 19,33 |
==================================================================================|
|     06     |     Doces    |                Bomba de Creme            | R$ 17,71 |        
==================================================================================|
|     07     |     Doces    |               Bomba de Morango           | R$ 04,82 |
==================================================================================|
|     08     |  Sanduíches  |     Filé-Mignon com fritas e cheddar     | R$ 21,16 |
==================================================================================|
|     09     |  Sanduíches  |Hambúrguer com queijos,champignon e rúcula| R$ 12,70 |
==================================================================================|
|     10     |  Sanduíches  |             Provolone com salame         | R$ 19,70 |
==================================================================================|
|     11     |  Sanduíches  |           Vegetariano de Beringela       | R$ 28,22 |
==================================================================================|
|     12     |    Pizzas    |                  Calabresa               | R$ 08,98 |
==================================================================================|
|     13     |    Pizzas    |                  Napolitana              | R$ 00,42 |
==================================================================================|
|     14     |    Pizzas    |                   Peruana                | R$ 18,36 |
==================================================================================|
|     15     |    Pizzas    |                  Portuguesa              | R$ 27,50 |
==================================================================================|
|             16            |                     SAIR                            |
==================================================================================|");

            int menuDesejado = 0, bolosQuantidade = 0, sanduichesQuantidade = 0, pizzasQuantidade = 0, docesQuantidade = 0;
            double valorProduto = 0;
            while (menuDesejado != 16)
            {
                Console.Write("Informe as opções desejadas: ");
                menuDesejado = Convert.ToInt32(Console.ReadLine());
                if ((menuDesejado > 0) && (menuDesejado < 6))
                {
                    bolosQuantidade = bolosQuantidade + 1;
                    if (menuDesejado == 1)
                    {
                        valorProduto = valorProduto + 29.50;
                    }
                    else if (menuDesejado == 2)
                    {
                        valorProduto = valorProduto + 2;
                    }
                    else if (menuDesejado == 3)
                    {
                        valorProduto = valorProduto + 29.23;
                    }
                    else if (menuDesejado == 4)
                    {
                        valorProduto = valorProduto + 7.10;
                    }
                    else
                    {
                        valorProduto = valorProduto + 19.33;
                    }
                }
                else if ((menuDesejado > 5) && (menuDesejado < 8))
                {
                    docesQuantidade = docesQuantidade + 1;
                    if (menuDesejado == 6)
                    {
                        valorProduto = valorProduto + 17.71;
                    }
                    else
                    {
                        valorProduto = valorProduto + 4.82;
                    }
                }
                else if ((menuDesejado > 7) && (menuDesejado < 12))
                {
                    sanduichesQuantidade = sanduichesQuantidade + 1;
                    if (menuDesejado == 8)
                    {
                        valorProduto = valorProduto + 21.16;
                    }
                    else if (menuDesejado == 9)
                    {
                        valorProduto = valorProduto + 12.70;
                    }
                    else if (menuDesejado == 10)
                    {
                        valorProduto = valorProduto + 19.70;
                    }
                    else
                    {
                        valorProduto = valorProduto + 28.22;
                    }
                }
                else if ((menuDesejado > 11) && (menuDesejado < 16))
                {
                    pizzasQuantidade = pizzasQuantidade + 1;
                    if (menuDesejado == 12)
                    {
                        valorProduto = valorProduto + 8.98;
                    }
                    else if (menuDesejado == 13)
                    {
                        valorProduto = valorProduto + 0.42;
                    }
                    else if (menuDesejado == 14)
                    {
                        valorProduto = valorProduto + 18.36;
                    }
                    else
                    {
                        valorProduto = valorProduto + 27.50;
                    }
                }
            }
            double mediaProdutos = valorProduto / (pizzasQuantidade + sanduichesQuantidade + docesQuantidade + bolosQuantidade);
            Console.WriteLine("Quantidade de bolos escolhidos: " + bolosQuantidade +
                              "\n Quantidade de doces escolhidos: " + docesQuantidade +
                              "\n Quantidade de sanduíches escolhidos : " + sanduichesQuantidade +
                              "\n Quantidade de pizzas escolhidas: " + pizzasQuantidade +
                              "\n Média dos produtos: R$ " + mediaProdutos);
        }
    }
}
