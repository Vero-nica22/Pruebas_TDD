using Xunit;

using CalculadoraApp;

namespace CalculadoraTest.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Suma()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(20, 2);
            Assert.Equal(22, resultado);
        }
        [Fact]
        public void Resta()
        {
            //Inicializar los datos
            Calculadora calculadora = new Calculadora();
            int numero1 = 10;
            int numero2 = 5;
            int resultado = 5;

            //Probar codigo
            int resultadoReal = calculadora.Restar(numero1, numero2);

            //Verificacion
            Assert.Equal(resultado, resultadoReal);
        }

        [Fact]
        public void Multiplicacion()
        {
            // Inicializacion
            Calculadora calculadora = new Calculadora();
            int num1 = 3;
            int num2 = 4;
            int resultado = 12;

            //Prueba
            int resultadoReal = calculadora.Multiplicar(num1, num2);


            //Verificacion
            Assert.Equal(resultado, resultadoReal);
        }

        [Fact]
        public void Division()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(-20, 2);
            Assert.Equal(-10, resultado);
        }

        // [Fact]
        // public void ingresarLetraSuma()
        // {
        //     var calculadora = new Calculadora();
        //     var resultado = calculadora.Sumar("x", "v");
        //     Assert.Equal("Los valores ingresados no pueden ser letras", resultado);
        // }

        // [Fact]
        // public void ingresarLetraResta()
        // {
        //     var calculadora = new Calculadora();
        //     var resultado = calculadora.Restar("x", "v");
        //     Assert.Equal("Los valores ingresados no pueden ser letras", resultado);
        // }

        // [Fact]
        // public void ingresarLetraMulti()
        // {
        //     var calculadora = new Calculadora();
        //     var resultado = calculadora.Multiplicar("x", "v");
        //     Assert.Equal("Los valores ingresados no pueden ser letras", resultado);
        // }

        // [Fact]
        // public void ingresarLetraDivision()
        // {
        //     var calculadora = new Calculadora();
        //     var resultado = calculadora.Dividir("x", "v");
        //     Assert.Equal("Los valores ingresados no pueden ser letras", resultado);
        // }

    }
}