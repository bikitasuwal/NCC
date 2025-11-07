using System;
using System.IO;

namespace Bikita_4_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter numerator: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException caught: " + ex.Message);
            }
            try
            {
                Console.Write("\nEnter a string: ");
                string input = Console.ReadLine();

                string str = string.IsNullOrEmpty(input) ? null : input;
                Console.WriteLine("String length: " + str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException caught: " + ex.Message);
            }
            try
            {
                int[] numbers = { 10, 20, 30 };
                Console.Write("\nEnter index (0–2) to access array: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Element at index " + index + " = " + numbers[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
            }
            try
            {
                Console.Write("\nEnter filename to read: ");
                string filename = Console.ReadLine();

                using (StreamReader reader = new StreamReader(filename))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("\nFile content:\n" + content);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException caught: " + ex.Message);
            }
            try
            {
                Console.Write("\nEnter a number as string: ");
                object obj = Console.ReadLine();
                int num = (int)obj;
                Console.WriteLine("Number = " + num);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException caught: " + ex.Message);
            }

        }
    }
}
