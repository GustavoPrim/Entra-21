using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio05
    {
        public void Executar()
        {
            var codigoSelecionado = 0;
            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizzas = 0;
            var valorProdutos = 0.0;
            var somaProdutos = 0.0;

            while (codigoSelecionado != 16)
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
                var menuValido = false;
                while (menuValido == false)
                {
                    try
                    {
                        Console.Write("Digite o código do produto desejado: ");
                        codigoSelecionado = Convert.ToInt32(Console.ReadLine());
                        if (codigoSelecionado < 0 || codigoSelecionado > 16)
                        {
                            Console.WriteLine("Produto selecionado não existe. Digite novamente");
                        }
                        else
                        {
                            menuValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Código de produto não é válido. Informe novamente");
                    }
                }
                if (codigoSelecionado > 0 && codigoSelecionado < 6)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    if (codigoSelecionado == 1)
                    {
                        valorProdutos = 29.50;
                    }
                    else if (codigoSelecionado == 2)
                    {
                        valorProdutos = 2.0;
                    }
                    else if (codigoSelecionado == 3)
                    {
                        valorProdutos = 29.23;
                    }
                    else if (codigoSelecionado == 4)
                    {
                        valorProdutos = 7.10;
                    }
                    else if (codigoSelecionado == 5)
                    {
                        valorProdutos = 19.33;
                    }
                }
                else if (codigoSelecionado > 5 && codigoSelecionado < 8)
                {
                    quantidadeDoces = quantidadeBolos + 1;
                    if (codigoSelecionado == 6)
                    {
                        valorProdutos = 17.71;
                    }
                    else if (codigoSelecionado == 7)
                    {
                        valorProdutos = 4.82;
                    }
                }
                else if (codigoSelecionado > 7 && codigoSelecionado < 12)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    if (codigoSelecionado == 8)
                    {
                        valorProdutos = 21.16;
                    }
                    else if (codigoSelecionado == 9)
                    {
                        valorProdutos = 12.70;
                    }
                    else if (codigoSelecionado == 10)
                    {
                        valorProdutos = 19.70;
                    }
                    else if (codigoSelecionado == 11)
                    {
                        valorProdutos = 28.22;
                    }
                }
                else if (codigoSelecionado > 11 && codigoSelecionado < 16)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    if(codigoSelecionado == 12)
                    {
                        valorProdutos = 8.98;
                    }
                    else if (codigoSelecionado == 13)
                    {
                        valorProdutos = 0.42;
                    }
                    else if (codigoSelecionado == 14)
                    {
                        valorProdutos = 18.36;
                    }
                    else if (codigoSelecionado == 15)
                    {
                        valorProdutos = 27.50;
                    }
                }
                somaProdutos = somaProdutos + valorProdutos;
            }
            var mediaProdutos = somaProdutos / (quantidadeBolos + quantidadeDoces + quantidadePizzas + quantidadeSanduiches);
            Console.WriteLine("Quantidade de bolos escolhidos: " + quantidadeBolos + 
                            "\nQuantidade de doces escolhidos: " + quantidadeDoces +
                            "\nQuantidade de pizzas escolhidos: " + quantidadePizzas +
                            "\nQuantidade de sanduíches escolhidos: " + quantidadeSanduiches + 
                            "\nMédia dos produtos:R$ " + mediaProdutos);
        }
    }
}
