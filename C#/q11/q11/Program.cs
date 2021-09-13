using System;

namespace q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, c, upr, lwr;
            Console.Write("enetr the lower range" + " ");
            lwr = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the upper range " + " ");
            upr = Convert.ToInt32(Console.ReadLine());


            for (num = lwr; num <= upr; num++)
            {
                c = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        c++;
                        break;
                    }
                }

                if (c == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}
