using Xunit;
using CalculadoraTest; 

namespace CalculadoraTest.Tests
{
    public class CalculadoraTests
    {
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


    }
}