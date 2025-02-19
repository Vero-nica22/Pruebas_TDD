using System;

namespace CalculadoraTest
{

    public class Calculadora
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Ingresa el número 1:");
            string num1Insert = Console.ReadLine(); 

            Console.WriteLine("Ingresa el número 2:");
            string num2Insert = Console.ReadLine(); 

           
            if (!int.TryParse(num1Insert, out int num1) || !int.TryParse(num2Insert, out int num2))
            {
                Console.WriteLine("Los valores ingresados no son validos (Ingrese números enteros)");
                return; 
            }

            Console.WriteLine("Seleccione el tipo de operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            string opcionI = Console.ReadLine();

            if (!int.TryParse(opcionI, out int opcion))
            {
                Console.WriteLine("Opción inválida. Ingrese un número del 1 al 4.");
                return;
            }


            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {calculadora.Sumar(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {calculadora.Restar(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {calculadora.Multiplicar(num1, num2)}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {calculadora.Dividir(num1, num2)}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}

