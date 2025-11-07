using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondclass_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2,3);
            rect.Display();
            Console.ReadLine();
        }
    }
    public class Rectangle 
    {
        int x,y;
        public Rectangle()
        {
           // x = 5;
        }
        public Rectangle(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine(x+y);
        }
    }
}
