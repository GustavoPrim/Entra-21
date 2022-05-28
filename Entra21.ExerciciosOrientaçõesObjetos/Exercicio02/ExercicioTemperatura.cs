using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacoesObjetos.Exercicio02
{
    public class ExercicioTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();

            Console.Write("Informe o valor da temperatura: ");
            temperatura.TemperaturaValor = Convert.ToDouble(Console.ReadLine());

            var table = new ConsoleTable("Código", "Temperaturas");

            table.Configure(x => x.EnableCount = false);

            table.AddRow("1", "Fahrenheit")
                .AddRow("2", "Celsius")
                .AddRow("3", "Kelvin");

            table.Write();

            Console.Write("Informe a sua temperatura de origem: ");
            temperatura.TemperaturaOrigem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a sua temperatura de destino: ");
            temperatura.TemperaturaDestino = Convert.ToDouble(Console.ReadLine());
            
            Console.Clear();

            temperatura.ApresentarTemperaturaConvertida();
        }
    }
}
