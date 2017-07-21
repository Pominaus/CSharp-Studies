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
            CSVRead.ReadCSV.PrintCSV(CSVRead.ReadCSV.FilePath);
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
