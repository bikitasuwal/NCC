using System;
using System.IO;

namespace Bikita_4_fileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\BikitafileLab.txt";
            //FileStream fs=File.Create(filePath);
            //fs.Close();
            FileStream fs =null;
            if (!File.Exists(filePath))
            { 
                using (fs = File.Create(filePath))
                {
                   
                }
            }
            Console.WriteLine("File created successfully.");
            Console.ReadLine();

        }
    }
}
