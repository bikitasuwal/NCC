using System;
namespace Bikita_4_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setWidth(5);
            Rect.setHeight(10);
            Console.WriteLine("Total areas:"+Rect.getArea());
            Console.ReadLine();
        }
        class Shape
        {
            protected int width;
            protected int height;
            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }

        }
        class Rectangle : Shape
        {
            public int getArea()
            {
                return (width * height);
            }
        }
    }
}
