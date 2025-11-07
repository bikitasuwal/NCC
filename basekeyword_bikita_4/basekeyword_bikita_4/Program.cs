using System;
namespace basekeyword_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //derivedclass d = new derivedclass(); //derived class object created
            //d.derivedmethod(); //derived class method called
            //Console.ReadLine(); //wait for user input before closing the console window
            rectangle r = new rectangle();
            r.derivemethod(); //derived class method called
            Console.ReadLine(); //wait for user input before closing the console window
        }
    }
    //public class baseclass
    //{
    //    public string name;
    //    public baseclass()
    //    {
    //        name = "bikita";
    //    }
    //    public void basemethod()
    //    {
    //        Console.WriteLine("base method called");
    //    }

    //}
    //public class derivedclass : baseclass
    //{ 
    //    public derivedclass():base() //constructor caled
    //    {

    //    }
    //    public void derivedmethod()
    //    {
    //        base.basemethod(); //base class method called
    //        Console.WriteLine("base.name");
    //    }
    //}
    public class area
    {
        public int length, width;
        public area(int l, int w) //constructor with parameters
        {
            length = l;
            width = w;
        }
        public int getarea() //method to calculate area
        {
            return length * width;
        }
        public void displayarea() //method to display area
        {
            Console.WriteLine("Area is: " + getarea());
        }
    }
    public class rectangle : area
    {
        public rectangle() : base(10, 20) //calling base class constructor with parameters
        {
            //base class constructor       
        }
        public void derivemethod() //method to display rectangle area
        {
            base.displayarea(); //calling base class method to display area
        }
    }
}
