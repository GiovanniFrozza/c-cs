using System;

namespace funcoes
{
    class Program
    {
        static string Anagrama(string palavra)
        {
            string retorno = "";
            for(int a = palavra.Length-1; a >= 0; a--)
            {
                retorno += palavra[a];
            }
            return retorno;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string resultAnagrama = Anagrama(palavra);
            Console.WriteLine(resultAnagrama);
        }
    }
}
