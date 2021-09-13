using System;

namespace q7
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int sub = 0;
            int pro = 1;
            int div = 0;
            Console.WriteLine("enter number 1");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter a choice\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
            int ch = Convert.ToInt16(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    sum = a + b;
                    Console.WriteLine("the sum is" + "  " + sum);
                    break;

                case 2:
                    sub = a - b;
                    Console.WriteLine("the diff is" + "  " + sub);
                    break;
                case 3:
                    pro = a * b;
                    Console.WriteLine("the product is" + "  " + pro);
                    break;
                case 4:
                    sum = a / b;
                    Console.WriteLine("the divsion is" + "  " + div);
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
}