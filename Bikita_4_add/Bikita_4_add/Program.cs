using System;

namespace Bikita_4_add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            // Create object and pass values to constructor
            Addition obj = new Addition(n1, n2);

            // Display result
            Console.WriteLine("The sum of {0} and {1} is: {2}", n1, n2, obj.Add());
        }
        class Addition
        {
            private int num1;
            private int num2;
            // Constructor to initialize numbers
            public Addition(int n1, int n2)
            {
                num1 = n1;
                num2 = n2;
            }
            // Method to add the two numbers
            public int Add()
            {
                return num1 + num2;
            }
        }
    }
}
