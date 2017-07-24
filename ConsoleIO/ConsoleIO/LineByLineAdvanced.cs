using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleIO.RBLAdv
{
    public static class LineByLineAdvanced
    {
        public static string File {get; set;} = "SoccerGameResults.csv";
        public static string DirPath { get; set; } = Directory.GetCurrentDirectory();
        public static string FullPath => Path.Combine(DirPath, File);
        private static FileInfo _checkFile => new FileInfo(FullPath);
        private static List<string[]> _fileData = new List<string[]>();

        public static void Read()
        {
            if (_checkFile.Exists)
            {
                Console.WriteLine("\n\nFile {0}\n", _checkFile.Name);
                using (StreamReader reader = new StreamReader(FullPath))
                {
                    while (reader.Peek() != -1)
                    {
                        string[] line;
                        line = reader.ReadLine().Split(',');
                        foreach (string word in line)
                        {
                            Console.Write(word + " ");
                        }
                        Console.WriteLine();

                    }
                }
            }
        }

        public static void ReadData()
        {
            if(_checkFile.Exists)
            {
                using (StreamReader reader = new StreamReader(_checkFile.Name))
                {
                    while(reader.Peek() != -1)
                    {
                        _fileData.Add(reader.ReadLine().Split(','));
                    }

                }
                foreach(string[] line in _fileData)
                {
                    foreach(string word in line)
                    {
                        Console.Write(word + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Test()
        {
            Console.WriteLine(FullPath);
        }
    }
}
