using System;
using System.IO;

namespace move_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "";
            string destination = "";
            Console.Write("Enter the source path : ");
            source = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(source) || !File.Exists(source))
                return;
            Console.Write("Enter the destination folder : ");
            destination = Path.Combine(Console.ReadLine(), Path.GetFileName(source));
            while (true)
            {
                Console.WriteLine("\n1 - Move file to destination folder\n2 - Move file from destination to source folder\n3 - Exit");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key==ConsoleKey.D1)
                {
                    if (!File.Exists(source))
                    {
                        Console.WriteLine("Destination file does not exist");
                        continue;
                    }
                    File.Move(source, destination);
                    if (!File.Exists(destination))
                        Console.WriteLine("File was not moved.");
                }
                else if (key.Key==ConsoleKey.D2)
                {
                    if (!File.Exists(destination))
                    {
                        Console.WriteLine("Destination file does not exist");
                        continue;
                    }
                    File.Move(destination, source);
                    if (!File.Exists(source))
                        Console.WriteLine("File was not moved.");

                }
                else if (key.Key==ConsoleKey.D3)
                {
                    goto function2;
                }
                else
                {
                    goto function1;
                }
            }

        function1:
            Console.WriteLine("\nKey is not defined.\n Please press a key to exit...");
            Console.ReadKey();
        function2:
            Console.WriteLine("\nPlease press a key to exit...");
            Console.ReadKey();
        }
    }
}
