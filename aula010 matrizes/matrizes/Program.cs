using System;

namespace matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matriz = new char[2, 2] {
                {'A', 'B'},
                {'C', 'D'},
            };

            for (int linha = 0; linha < 2; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("{0} |",matriz[linha, coluna]);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
