using System;

namespace q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enterthe number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the width: ");
            int w = Convert.ToInt32(Console.ReadLine());

            int h = w;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(n);
                }

                Console.WriteLine();
                w--;
            }
        }
    }
}
