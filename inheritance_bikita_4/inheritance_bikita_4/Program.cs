using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.setWidth(5);
            rect.setHeight(6);
            Console.WriteLine("Total area: " + rect.getArea());
            Console.ReadLine();
        }
    }
    class Shape { 
        protected int width, height;
        public void setWidth(int w) {
            width = w;
        }
        public void setHeight(int h) {
            height = h;
        }
    }
    class Rectangle : Shape {
        public int getArea() {
            return width * height;
        }
    }
}
