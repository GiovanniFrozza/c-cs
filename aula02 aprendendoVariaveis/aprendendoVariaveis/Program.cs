using System;

namespace aprendendoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constante = "Esse valor não pode ser alterado durante a execução do programa";
            Console.WriteLine(constante);
            string variavel = "Este valor pode ser alterado a qualquer momento da execução do programa";
            Console.WriteLine(variavel);

            //constante = Console.ReadLine(); Constante
            Console.WriteLine(constante);
            variavel = Console.ReadLine(); // variavel
            Console.WriteLine(variavel);

            string nomeComposto; 
            nomeComposto = "Giovanni Frozza";//atribuicao de variavel
            Console.WriteLine(nomeComposto);
            nomeComposto = Console.ReadLine(); 
            Console.WriteLine(nomeComposto);

            Console.ReadKey();
        }
    }
}
