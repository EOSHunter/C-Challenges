using System;

namespace Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 5)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < (2 * i) - 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                i++;
            }
        }
    }
}