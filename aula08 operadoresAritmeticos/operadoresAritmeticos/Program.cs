using System;

namespace operadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 5;
            int valor2 = 4;

            Console.Write("valor 1: ");
            Console.WriteLine(valor1);

            Console.Write("valor 2: ");
            Console.WriteLine(valor2);

            Console.WriteLine("x-x-x-x-x-x-x-x-x");

            Console.Write("Soma: ");
            Console.WriteLine(valor1 + valor2);
            Console.Write("Subtração: ");
            Console.WriteLine(valor1 - valor2);
            Console.Write("Divisão: ");
            Console.WriteLine(valor1 / valor2);
            Console.Write("Multiplicação: ");
            Console.WriteLine(valor1 * valor2);
            Console.Write("Resto: ");
            Console.WriteLine(valor1 % valor2);

            Console.ReadKey();
        }
    }
}
