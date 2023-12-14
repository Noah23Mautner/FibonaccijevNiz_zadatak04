using System;

namespace fibonacijev_niz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj n:");
            int n = int.Parse(Console.ReadLine());

            int rezultat = FibonaccijevNiz(n);

            Console.WriteLine("n-ti član Fibonaccijevog niza je: " + rezultat);
        }

        static int FibonaccijevNiz(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                int a = 0;
                int b = 1;
                int rezultat = 0;

                for (int i = 2; i <= n; i++)
                {
                    rezultat = a + b;
                    a = b;
                    b = rezultat;
                }

                return rezultat;
            }
        }
    }
}
