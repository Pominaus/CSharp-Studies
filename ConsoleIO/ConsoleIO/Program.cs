using System;
using System.IO;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(workingDirectory);
            string filePath = Path.Combine(workingDirectory, "Data.txt");
            FileInfo file = new FileInfo(filePath);
            ReadByLine.LineByLine.Read();
            /*if (file.Exists)
            {

                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    var console = Console.In;
                    
                    for (int i = 0; i < 3; i++)
                    {
                        Console.SetIn(reader);
                        Console.WriteLine(Console.ReadLine());
                        Console.SetIn(console);
                        Console.ReadLine();
                    }
                }
            }
            
         */   
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
