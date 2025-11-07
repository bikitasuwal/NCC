using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicast_bikita_4
{
    public delegate void delmethod(int a, int b);
    public class multipledelegates
    {
        public void addmethod(int a, int b)
        {
            Console.WriteLine("Add Method: " + (a + b));
        }
        public void multiplymethod(int a, int b)
        {
            Console.WriteLine("Multiply Method: " + (a * b));
        }
        public void subtractmethod(int a, int b)
        {
            Console.WriteLine("Subtract Method: " + (a - b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            multipledelegates m = new multipledelegates();
            delmethod d = new delmethod(m.addmethod);
            d +=new delmethod(m.multiplymethod);
            d += new delmethod(m.subtractmethod);
            d(10, 5);
            Console.ReadLine();
        }
    }
}
