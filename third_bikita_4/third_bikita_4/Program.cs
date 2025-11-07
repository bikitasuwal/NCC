using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "biki"; // set or write
            //Console.WriteLine(student.Name); // student.name=read
            indexerClass indexer = new indexerClass();
            indexer[0] = "biki"; // set or write
            indexer[1] = "gita"; // set or write
            indexer[2] = "sita"; // set or write                         
            indexer[3] = "mita"; // set or write
            indexer[4] = "rita"; // set or write
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(indexer[i]);
            }
            Console.ReadLine();
        }
    }
    class indexerClass
    {
        private string[] names = new string[5];
        public string this[int i] // indexer property
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    //public class Student
    //{
    //    private string name;
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //}
}
