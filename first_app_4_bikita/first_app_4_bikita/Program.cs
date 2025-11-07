using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app_4_bikita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int item in intarray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine(); //cin
        }
    }
}
