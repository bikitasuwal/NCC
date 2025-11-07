using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hello h = new hello();
            h.showMessage();
            Console.ReadLine();
        }
    }
    abstract class message
    {
        public abstract void showMessage();
        public void txt()
        {
            Console.WriteLine("This is a message from the abstract class.");
        }
    }
    class hello : message
    {
        public override void showMessage()
        {
            Console.WriteLine("Hello, this is a message from the derived class.");
        }
    }
}
