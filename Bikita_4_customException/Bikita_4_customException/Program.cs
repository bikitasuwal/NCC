using System;

namespace Bikita_4_customException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    throw new InvalidAgeException("Age cannot be negative. Please enter a valid age!");
                }
                else if (age < 18)
                {
                    throw new InvalidAgeException("You must be at least 18 years old to register.");
                }
                else
                {
                    Console.WriteLine("Registration successful! Welcome!");
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input Error: Please enter a valid numeric value for age.");
            }
            finally
            {
                Console.WriteLine("\nProgram execution completed.");
            }
        }
    }
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
