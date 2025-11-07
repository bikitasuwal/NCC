using System;
namespace Bikita_4_areaPaint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(7);
            Rect.setHeight(9);
            area = Rect.getArea();
            // Print the area of the object.
            Console.WriteLine("Total area:" + Rect.getArea());
            Console.WriteLine("Total paint cost:" + Rect.getCost(area));
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
        public interface PaintCost
        {
            int getCost(int area);
        }
        class Rectangle : Shape, PaintCost
        {
            public int getArea()
            {
                return (width * height);
            }
            public int getCost(int area)
            {
                return area * 70;
            }
        }

    }
}

