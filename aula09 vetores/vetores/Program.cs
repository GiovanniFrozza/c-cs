using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo 1
            int valor1;
            int valor2;
            int valor3;
            int valor4;
            int valor5;

            int[] notas = new int[5];
            notas[0] = 7;
            notas[1] = 4;
            notas[2] = 9;
            notas[3] = 9;
            notas[4] = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            Console.WriteLine("A soma das notas é {0}", notas[4]);

            //exemplo 2
            int[] idade = new int[15] {16, 19, 24, 17, 15, 16, 19, 22, 21, 17, 18, 17, 15, 16, 20};
            int soma = 0;
            int mediaIdade;

            for(int a = 0; a < idade.Length; a++)
            {
                soma += idade[a];
                
            }
            mediaIdade = soma / 15;
            Console.WriteLine("A media da idade é de {0} anos", mediaIdade);

            //exemplo 3
            char[] texto = new char[5] { 's', 'e', 'n', 'a', 'i' };
            for(int a = 0; a < texto.Length; a++)
            {
                Console.WriteLine(texto[a]);
            }

            Console.ReadKey();
        }
    }
}
