 using System;

namespace lacoRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            while (cont < 10)
            {
                Console.WriteLine("Valor do cont no while = {0}", cont);
                cont++;
            }
            Console.WriteLine();

            for(int a = 0; a < 10; a++)
            {
                Console.WriteLine("Valor do cont no for = {0}", a);
            }
            Console.WriteLine();

            cont = 0;
            do
            {
                Console.WriteLine("Valor do cont no do/while = {0}", cont);
                cont++;
            } while (cont < 10);

            Console.ReadKey();
        }
    }
}
