using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikita_4_tryException
{
    internal class Program
    {
        static void RecursiveMethod()
        {
            RecursiveMethod(); // Causes stack overflow
        }

        static void Main()
        {
            try
            {
                // Divide by zero
                int a = 10, b = 5;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                // Null reference
                string str = null;
                Console.WriteLine(str.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                // Index out of range
                int[] arr = new int[3];
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                // IO exception
                using (StreamReader reader = new StreamReader("nofile.txt"))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                // Invalid cast
                object obj = "Hello";
                int x = (int)obj;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                // Stack overflow
                RecursiveMethod();
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Error: Stack overflow occurred.");
            }
        }
    }

}
