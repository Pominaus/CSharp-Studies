using System;
using System.IO;
using System.Collections.Generic;

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
            GetCSV.GetResults.HomeAway isHome;
            if(Enum.TryParse("Home", out isHome))
                {
                Console.WriteLine(isHome);
            }
            List<string> players = JsonRead.ReadJSON.GetPLayerNames();
            foreach(string name in players)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
