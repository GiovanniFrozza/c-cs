using System;

namespace operadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v = true;
            Boolean f = false;

            Console.WriteLine("==== Tabela Verdade ====");
            Console.WriteLine(" ");
            Console.WriteLine("Operadores Logicos 'E' ");
            Console.WriteLine(string.Format("{0} E {1} => {2}", v, v, v & v));
            Console.WriteLine(string.Format("{0} E {1} => {2}", v, f, v & f));
            Console.WriteLine(string.Format("{0} E {1} => {2}", f, v, f & v));
            Console.WriteLine(string.Format("{0} E {1} => {2}", f, f, f & f));

            Console.WriteLine(" ");
            Console.WriteLine("Operadores Logicos 'OU' ");
            Console.WriteLine(string.Format("{0} OU {1} => {2}", v, v, v || v));
            Console.WriteLine(string.Format("{0} OU {1} => {2}", v, f, v || f));
            Console.WriteLine(string.Format("{0} OU {1} => {2}", f, v, f || v));
            Console.WriteLine(string.Format("{0} OU {1} => {2}", f, f, f || f));

            Console.WriteLine(" ");
            Console.WriteLine("Operadores Logicos 'NEGAÇÃO' ");
            Console.WriteLine(string.Format("Não {0} => {1}", v, !v));
            Console.WriteLine(string.Format("Não {0} => {1}", f, !f));
            
            Console.ReadKey();
        }
    }
}
