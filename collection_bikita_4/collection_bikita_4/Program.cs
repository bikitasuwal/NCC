using System;

namespace GenericExample
{
    class Data<T>
    {
        T number;
        public Data(T value)


        {
            number = value;
        }
        public T Number
        {
            get { return number; }
            set { number = value; }
        }
        public void Display()
        {
            Console.WriteLine("The value is: " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data<int> usingint = new Data<int>(10);
            usingint.Display();

            Data<string> stringHolder = new Data<string>("Hello");
            stringHolder.Display();

            Data<double> doubleHolder = new Data<double>(3.14);
            doubleHolder.Display();

            Console.ReadLine();
        }
    }
}
