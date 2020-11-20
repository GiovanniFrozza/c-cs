using System;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;

            Console.Write("Digite seu primeiro nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Seja bem vindo " + nome + " " + sobrenome);
        }
    }
}
