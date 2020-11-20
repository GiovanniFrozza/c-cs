using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            int limite = 250;
            int valorSaque;

            Console.WriteLine("Digite o valor do saque: ");
            valorSaque = Convert.ToInt32(Console.ReadLine());

            if(valorSaque <= 0 || valorSaque > limite)
            {
                Console.WriteLine("Valor indisponivel.");
            } else if (valorSaque <= saldo)
            {
                saldo -= valorSaque;
                Console.WriteLine("Saque liberado! Seu novo saldo é de " + saldo);
            } else if (valorSaque > saldo && valorSaque <= limite)
            {
                saldo -= valorSaque;
                Console.WriteLine("Valor liberado! Voce ficou com " + saldo + " em debito.");
            }

            Console.ReadKey();
        }
    }
}
