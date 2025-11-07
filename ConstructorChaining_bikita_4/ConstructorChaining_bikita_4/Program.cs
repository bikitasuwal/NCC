using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            testone t1 = new testone();
            Console.ReadLine();
        }
    }
    public class test
    {
        public test(): this(1)
        {
            Console.WriteLine("one");
        }
        public test(int x) : this(1,2)
        { 
            Console.WriteLine("two");
        }
        public test(int x, int y) 
        {
            Console.WriteLine("three");
        }
    }
    public class testone
    {
        public testone() : base()
        {
            Console.WriteLine("four");
        }
    }

}
