using Entra21.ExerciciosOrientacoesObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacoesObjetos.Tests.Exercicio02.tests
{
    public class TemperaturaTests
    {
        [Fact]

        public void Validar_Fahrenheit_Para_Celsius()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 1;
            temperatura.TemperaturaDestino = 2;
            temperatura.TemperaturaValor = 30;

            var temperaturaConvertida = temperatura.CalcularFahrenheitParaCelsius();

            temperaturaConvertida.Should().Be(-1.1111111111111112);
        }

        [Fact]

        public void Validar_Fahrenheit_Para_Kelvin()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 1;
            temperatura.TemperaturaDestino = 3;
            temperatura.TemperaturaValor = 30;

            var temperaturaConvertida = temperatura.CalcularFahrenheitParaKelvin();

            temperaturaConvertida.Should().Be(272.0388888888889);
        }
    }
}
