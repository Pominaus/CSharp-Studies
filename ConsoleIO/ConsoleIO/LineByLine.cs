using System;
using System.IO;

//###########################################################################
//                  Not Currently Connected to Project
//###########################################################################

namespace ConsoleIO.ReadByLine
{
    public static class LineByLine
    {
        private static string _fileName = "Data.txt";
        private static int _linesInFile = 3;
        private static string _path = Directory.GetCurrentDirectory();
        private static FileInfo _file = new FileInfo(Path.Combine(_path, _fileName));
        
        public static void Read()
        {
            if(_file.Exists)
            {
                TextReader defaultConsole = Console.In;
                using (StreamReader reader = new StreamReader(_file.Name))
                {
                    for(; _linesInFile > 0; _linesInFile--)
                    {
                        Console.SetIn(reader);
                        Console.WriteLine(Console.ReadLine());
                        Console.SetIn(defaultConsole);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
    


}