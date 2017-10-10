using System;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 50)
            {
                Console.Write("*");
                i++;
                if (i == 10 || i == 20 || i == 30 || i == 40)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}