using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] intarr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("for loop");
            //for (int i = 0; i < intarr.Length; i++)
            //{
            //    Console.WriteLine(intarr[i]);
            //}
            //Console.WriteLine("foreach loop");
            //foreach (int item in intarr)
            //{
            //    Console.WriteLine(item);
            //}
            //int[,] intarr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(intarr[i,j]);

            //    }
            //    Console.WriteLine("Next Row");
            //}
            int sum = 0;
            int[][] scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 10, 20, 30, 40 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    Console.WriteLine(scores[i][j] + " ");
                    sum += Convert.ToInt32(scores[i][j]);
                }
                Console.WriteLine("=" + sum);
                sum = 0; // Reset sum for the next row
                Console.WriteLine(" ");
            }
            int a = 5;
            int b = 2;
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
            Console.WriteLine("{0}+{1}={2}", a, b, c);

            B bee = new B();
            Console.WriteLine(bee.methodA());
            Console.WriteLine(bee.methodB());
            Console.ReadLine();

            c obj = new C();
        }
    }
    class A
    {
        public string methodA()
        {
            return ("Method A in class A");
        }
    }
    class B : A
    {
        public string methodB()
        {
            return ("Method B in class B");
        }
    }
    interface I1
    {
        string methodA();
    }
    interface I2
    {
        string methodB();
    }
    class C : I1, I2
    {
        public string methodA()
        {
            return ("Method A in class C implementing I1");
        }
        public string methodB()
        {
            return ("Method B in class C implementing I2");
        }
    }
}
