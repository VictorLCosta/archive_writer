using System;
using System.IO;

namespace ArchiveWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Victor\Desktop\Projetos C#\summary.csv";

            Console.WriteLine("Get directory separator char: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Get path separator: " + Path.PathSeparator);
            Console.WriteLine("Get directory name: " + Path.GetDirectoryName(path));
            Console.WriteLine("Get file name: " + Path.GetFileName(path));
            Console.WriteLine("Get file extension: " + Path.GetExtension(path));
            Console.WriteLine("Get file name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Get full path: " + Path.GetFullPath(path));
            Console.WriteLine("Get temp path: " + Path.GetTempPath()); 
            
        }
    }
}
