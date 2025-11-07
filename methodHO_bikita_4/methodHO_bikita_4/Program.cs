using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHO_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            people p1 = new student();
            people p2 = new teacher();
            p1.message();
            p2.message(); 
            Console.ReadLine();
        }
    }
    public class people
    {
        public virtual void message()
        {
            Console.WriteLine("Hello");
        }
    }
    public class  student : people
    {
        public override void message()
        {
            Console.WriteLine("Hello, I am a student");
        }

    }
    public class teacher : people
    {
        public override void message()
        {
            Console.WriteLine("Hello, I am a teacher");
        }
    }
    }
