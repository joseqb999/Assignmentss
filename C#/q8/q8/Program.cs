using System;

namespace q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float avgw = 0;
            Console.WriteLine("enter number 1");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 3");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 4");
            int d = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 5");
            int e = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 6");
            int f = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 7");
            int g = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 8");
            int h = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 9");
            int i = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 10");
            int j = Convert.ToInt16(Console.ReadLine());
            sum = a + b + c + d + e + f + g + h + i + j;
            Console.WriteLine("the sum is" + " " + sum);
            avgw = sum / 10;
            Console.WriteLine("the sum is" + " " + avgw);
        }
    }
}
