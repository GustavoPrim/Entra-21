using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int hora = 23;
            while (hora >= 0)
            {
                int minutos = 59;
                while (minutos >= 0)
                {
                    int segundos = 59;
                    while (segundos >= 0)
                    {
                        Console.WriteLine(hora + ":" + minutos + ":" + segundos);
                        segundos = segundos - 1;
                    }
                    minutos = minutos - 1;
                }
                hora = hora - 1;
            }
        }
    }
}
