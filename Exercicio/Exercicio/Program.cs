using System;

namespace Exercicio
{
    class Program
    {
        static void areaMetodo()
        {
            double pi = 3.14;

            Console.WriteLine("Digite o valor da area: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            raio = 4 * (pi * Math.Pow(raio,2));
            Console.WriteLine(raio);
        }
        static void expoenteMetodo()
        {
            Console.WriteLine("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            for(int a = 2; a < 5; a++)
            {
                double resultado;
                resultado = Math.Pow(valor, a);
                Console.WriteLine(resultado);
            }
        }

        static void celsiusMetodo()
        {
            Console.WriteLine("Digite a temperatura em graus fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = 9 * (fahrenheit / 5) + 32;
            Console.WriteLine(celsius);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o exercicio");
            Console.WriteLine("1: Area da esfera ");
            Console.WriteLine("2: Expoente");
            Console.WriteLine("3: Fahrenheit para Celsius");

            int exercicio = Convert.ToInt32(Console.ReadLine());

            switch (exercicio) {
                case 1:
                    areaMetodo();
                    break;
                case 2:
                    expoenteMetodo();
                    break;
                case 3:
                    celsiusMetodo();
                    break;
                default:
                    Console.WriteLine("Valor invalido;");
                    break;


            }
        }
    }
}
