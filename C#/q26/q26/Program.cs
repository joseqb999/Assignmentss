using System;

namespace q26
{
    class Program
    {
        static void Main(string[] args)
        {
            genericSwap<int> Swap = new genericSwap<int>();
            Swap.swapFunction(4, 5);
        }
    }
    class genericSwap<T>
    {
        public void swapFunction(int num1, int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swapping {num1},{num2}");
        }
    }
}
