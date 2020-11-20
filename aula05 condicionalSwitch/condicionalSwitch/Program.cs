using System;

namespace condicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("1 - Água");
            Console.WriteLine("2 - Água com Gás");
            Console.WriteLine("3 - Coca-Cola");
            Console.WriteLine("4 - Fanta");
            Console.WriteLine("5 - Sprite");
            Console.WriteLine("6 - Guaraná");
            Console.WriteLine();

            Console.Write("Digite o código de bebida que deseja: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Voce escolheu Água.");
                    break;
                case 2:
                    Console.WriteLine("Voce escolheu Água com Gás.");
                    break;
                case 3:
                    Console.WriteLine("Voce escolheu Coca-Cola.");
                    break;
                case 4:
                    Console.WriteLine("Voce escolheu Fanta.");
                    break;
                case 5:
                    Console.WriteLine("Voce escolheu Sprite.");
                    break;
                case 6:
                    Console.WriteLine("Voce escolheu Guaraná.");
                    break;
                default:
                    Console.WriteLine("Bebida não disponivel.");
                    break;
            }


            Console.ReadKey();
        }
    }
}
