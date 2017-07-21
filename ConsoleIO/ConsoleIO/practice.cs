using System;
using System.IO;

namespace Bob
{
    public class ReadFile
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