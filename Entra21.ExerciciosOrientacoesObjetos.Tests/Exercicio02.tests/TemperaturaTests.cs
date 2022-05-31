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

        [Fact]

        public void Validar_Celsius_Para_Fahrenheit()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 2;
            temperatura.TemperaturaDestino = 1;
            temperatura.TemperaturaValor = 30;

            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            temperaturaConvertida.Should().Be(86);
        }

        [Fact]

        public void Validar_Celsius_Para_Kelvin()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 2;
            temperatura.TemperaturaDestino = 3;
            temperatura.TemperaturaValor = 30;

            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            temperaturaConvertida.Should().Be(303.15);
        }

        [Fact]

        public void Validar_Kelvin_Para_Fahrenheit()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 3;
            temperatura.TemperaturaDestino = 1;
            temperatura.TemperaturaValor = 30;

            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();

            temperaturaConvertida.Should().Be(-405.67);
        }

        [Fact]

        public void Validar_Kelvin_Para_Celsius()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 3;
            temperatura.TemperaturaDestino = 2;
            temperatura.TemperaturaValor = 30;

            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            temperaturaConvertida.Should().Be(-243.14999999999998);
        }
    }
}
