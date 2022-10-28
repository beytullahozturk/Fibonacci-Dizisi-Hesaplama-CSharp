using System;

namespace FibonacciSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, c, sayi;
            Console.Write("Hesaplanacak eleman sayısını girin: ");
            sayi = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " "); 
            for (int i = 2; i < sayi; ++i)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
