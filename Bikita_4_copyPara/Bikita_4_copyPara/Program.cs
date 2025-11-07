using System;
using System.IO;
using System.Linq;
using System.Text;
namespace Bikita_4_copyPara
{
    internal class Program
    {
        static void Main()
        {
            string inputPath = @"E:\one.txt";
            string outputPath = @"E:\two.txt";

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("File one.txt does not exist.");
                return;
            }

            // Read all text from one.txt
            string text = File.ReadAllText(inputPath);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!' }, StringSplitOptions.RemoveEmptyEntries);

            // Open output file using FileStream
            using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            {
                foreach (string word in words)
                {
                    if ("aeiouAEIOU".Contains(word[0]))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(word + " ");
                        fs.Write(data, 0, data.Length);
                    }
                }
            }

            Console.WriteLine("Words starting with vowels copied to two.txt");

            // Optional: Read back to verify
            string result = File.ReadAllText(outputPath);
            Console.WriteLine("Contents of two.txt: " + result);
        }
    }

}
