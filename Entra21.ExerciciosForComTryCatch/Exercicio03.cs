using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
{
    internal class Exercicio03
    {
        public void Executar()
        {
            var numeroValido = false;
            var numero = 0.0;

            while (numeroValido == false)
            {
                try
                {
                    Console.Write("Informe um número para ser apresentado a sua tabuada: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    numeroValido = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Número digitado não é válido.Informe novamente");
                }
            }
            for (var i = 0; i <= 1000; i++)
            {
                Console.WriteLine(numero + " * " + i + " = " + (numero * i));
            }

        }
    }
}
