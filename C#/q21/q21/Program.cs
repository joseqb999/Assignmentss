using System.IO;

namespace q21
{
    class Program
    {
        static void Main(string[] args)
        {
            var writeMe = "File content";
            File.WriteAllText("output.txt", writeMe);

        }
    }
}