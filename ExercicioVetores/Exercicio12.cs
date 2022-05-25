using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio12
    {
        public void Executar()
        {
            var numeros = new int[10];
            var numerosCrescentes = new int[10];
            var numerosApresentar = "";
            var crescentesApresentar = "";

            for(var i = 0; i < numeros.Length; i++)
            {
                var numeroValido = false;
                while(numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe um número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        numeroValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Número digitado é inválido, digite um número novamente.");
                    }
                }
            }
            var contador = 1;
            for(var i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] < numeros[contador])
                {
                    numerosCrescentes[i] = numeros[i];
                    crescentesApresentar = crescentesApresentar + numerosCrescentes[i] + ", ";
                }
                else
                {
                    numeros[i] = numeros[contador];
                    numerosCrescentes[i] = numeros[contador];
                    crescentesApresentar = crescentesApresentar + numerosCrescentes[i] + ", ";
                }
                if (contador != numeros.Length - 1)
                {
                    contador++;
                }
                numerosApresentar = numerosApresentar + numeros[i] + ", ";
            }
            Console.WriteLine($"Numeros: {numerosApresentar}");
            Console.WriteLine($"Ordem crescente: {crescentesApresentar}");
        }
    }
}
