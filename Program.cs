using System;
using System.IO;

namespace ArchiveWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Victor\Desktop\ChessSystem\text1.txt";

            using (StreamReader sr = File.OpenText(path)) 
            {
                while (!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}
