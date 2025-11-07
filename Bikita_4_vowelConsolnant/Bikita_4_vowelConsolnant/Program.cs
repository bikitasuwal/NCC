using System;
using System.IO;
using System.Linq;
namespace Bikita_4_vowelConsolnant
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            using (FileStream vowelFile = new FileStream("vowel.txt", FileMode.Append, FileAccess.Write))
            using (FileStream consonantFile = new FileStream("consonant.txt", FileMode.Append, FileAccess.Write))
            {
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        byte[] data = new byte[] { (byte)c };
                        if ("aeiouAEIOU".Contains(c))
                            vowelFile.Write(data, 0, data.Length);
                        else
                            consonantFile.Write(data, 0, data.Length);
                    }
                }
            }

            Console.WriteLine("Vowels written to vowel.txt");
            Console.WriteLine("Consonants written to consonant.txt");
            //Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
        }
    }
}
