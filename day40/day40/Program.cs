using System;

class day40
{
    static day40()
    {
        Console.WriteLine("Static constructor called.");
    }

    public day40()
    {
        Console.WriteLine("Instance constructor called.");
    }
}

class Program
{
    static void Main()
    {
        day40 d1 = new day40();
        day40 d2 = new day40();
        Console.ReadLine();
    }
}
