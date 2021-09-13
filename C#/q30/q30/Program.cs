using System;

namespace Q30
{
    class Program
    {

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            Action<int> printActionDel = ConsolePrint;



            printActionDel(20);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


        }
        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}