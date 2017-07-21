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
            FileInfo[] files = directory.GetFiles("*.txt");
            foreach(var file in files)
            {
                Console.WriteLine(file.Name);
                
            }
            
            Bob.ReadFile.SubMain();
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
