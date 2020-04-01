using System;
using System.IO;
using System.Globalization;
using ArchiveWriter.Entities;

namespace ArchiveWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string source_path = Console.ReadLine();
            string[] lines = File.ReadAllLines(source_path);

            try 
            {
                
                string source_folder = Path.GetDirectoryName(source_path);
                string target_folder = source_folder + @"\out";
                string target_file = target_folder + @"\summary.csv";

                Directory.CreateDirectory(target_folder);

                using (StreamWriter sw = File.AppendText(target_file)) 
                {
                    foreach (string line in lines) 
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        Console.WriteLine(prod);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
