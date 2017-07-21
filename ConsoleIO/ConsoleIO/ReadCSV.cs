using System;
using System.IO;

//###########################################################################
//                  Not Currently Connected to Project
//###########################################################################

namespace ConsoleIO.CSVRead
{
    public static class ReadCSV
    {
        public static string File { get; private set;} = "SoccerGameResults.csv";
        public static string PathTo { get; private set; } = Directory.GetCurrentDirectory();
        public static string FilePath { get; private set; } = Path.Combine(PathTo, File);


        public static void PrintCSV(string FilePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string[] fileLines = reader.ReadToEnd().Split(new char[] { '\n'});
                    foreach(var line in fileLines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("OOPS! The Following Error Occured: " + ex.Message);
            }

        }
    }
}
