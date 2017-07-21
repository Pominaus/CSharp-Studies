using System;
using System.IO;

//###########################################################################
//                  Not Currently Connected to Project
//###########################################################################

namespace ConsoleIO.DirInfo
{
    public class ReadDir
    {
        public static void SubMain()
        {

            string path = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirectory = new DirectoryInfo(path);
            FileInfo[] files = currentDirectory.GetFiles();
            foreach(var file in files)
            {
                Console.WriteLine(file);
                Console.ReadLine();
            }
            
        }
    }
}