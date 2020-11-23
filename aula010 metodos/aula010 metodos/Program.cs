using System;

namespace aula010_metodos
{
    class Program
    {
        public static void CincoPorExtensso()
        {
            Console.WriteLine("cinco");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 0 a 9");
            string entrada = Console.ReadLine();

            while (entrada != "0")
            {
                if(entrada == "5")
                {
                    CincoPorExtensso();
                } 
                else
                {
                    Console.WriteLine(entrada);
                }
                Console.WriteLine("Digite um numero de 0 a 9");
                entrada = Console.ReadLine();
            }

            Console.ReadKey();
        }

    }
}
