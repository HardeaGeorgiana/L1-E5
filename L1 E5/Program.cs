using System;

namespace L1_E5
{
    /* E.5 Se citesc doua numere de la tastatura, x,y. 
           Scrieti un program care va afisa cele doua valori in ordine crescatoare.
    */
       class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Introduceti primul numar");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine($"{x},{y}");
            }
            else
            {
                Console.WriteLine($"{y},{x}");
            }
        }
    }
}
