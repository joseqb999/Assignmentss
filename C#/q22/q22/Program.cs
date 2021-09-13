using System;
using System.IO;

namespace ReadToEndEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"D:\Training\C#\q22\jose.txt";

            using var sr = new StreamReader(fileName);

            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}