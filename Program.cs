using System;

namespace CevrimlerleUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = 0;
            do
            {
                x = n + x;
                n = n + 1;
            } while (n < 10);

            Console.WriteLine(x);

            int A = 0;
            int B = 2;
            do
            {
                A = A + B;
                B = B + 2;
            } while (B<=10);  

            Console.WriteLine(A);

            int C = 70;
            if (C<=50)
            {
                Console.WriteLine("Sınıfını geçemedin.");
            }
            else if (C>=60)
            {
                Console.WriteLine("Sınıfını iyi ile geçtin.");

            }
            else if (C >= 70)
            {
                Console.WriteLine("Sınıfını pek iyi ile geçtin.");
            }
            else
            {
                Console.WriteLine("Sınıfını geçemedin.");
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                  Console.Write("{0},{1}", i, j);
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
        

    }
}
