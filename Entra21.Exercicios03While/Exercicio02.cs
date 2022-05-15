using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string nomeUsuario = "";
            int quantidade = 0;
            while (nomeUsuario != "fim")
            {
                Console.Write("Informe o nome: ");
                nomeUsuario = Console.ReadLine().ToLower().Trim();
                quantidade = quantidade + 1;
                Console.Clear();
            }
        }
    }
}
