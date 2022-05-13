using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio03
    {
        public void Executar()
        {
            int idadeUsuario = 0;
            while (idadeUsuario <= 128)
            {
                Console.Write("Idade: ");
                idadeUsuario = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
