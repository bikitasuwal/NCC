using System;
namespace delegate_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mydelegate d1 = DelegateExamples.display;
            Mydelegate d2 = new Mydelegate(DelegateExamples.show);
            Mydelegate d3 = new DelegateExamples().print;
            d1();
            d2();
            d3();
            Console.ReadLine();
        }
    }
    public delegate void Mydelegate();
    public class DelegateExamples
    {
        public static void display()
        {
            Console.WriteLine(" hello");
        }
        public static void show()
        {
            Console.WriteLine(" hi");
        }
        public void print()
        {
            Console.WriteLine(" welcome");
        }
    }
    
}
