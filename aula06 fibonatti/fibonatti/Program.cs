using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int prim = 0;
            int seg = 1;
            int aux = 0;
            Console.WriteLine(prim);
            Console.WriteLine(seg);

            while ((prim + seg) < 100000)
            {
                aux = prim + seg;
                Console.WriteLine(aux);
                prim = seg;
                seg = aux;
            }
            Console.ReadKey();
        }
    }
}
