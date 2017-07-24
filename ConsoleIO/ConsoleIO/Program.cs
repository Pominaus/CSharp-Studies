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
            RBLAdv.LineByLineAdvanced.Test();
            RBLAdv.LineByLineAdvanced.Read();
            RBLAdv.LineByLineAdvanced.ReadData();
            RBLAdv.LineByLineAdvanced.File = "TestFile.txt";
            RBLAdv.LineByLineAdvanced.DirPath = "/home/jon/bin/";
            RBLAdv.LineByLineAdvanced.Test();
            RBLAdv.LineByLineAdvanced.Read();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
