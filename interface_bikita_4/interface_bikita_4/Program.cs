using System;
namespace interface_bikita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imsg m1 = new implemented1();
            m1.hello();
            Imsg m2 = new implemented2();
            m2.hello();
            Console.ReadLine();
        }
    }
    interface Imsg
    {
        void hello();
    }
    class implemented1 : Imsg
    {
        public void hello()
        {
            Console.WriteLine("Hello from implemented class!");
        }
    }
    class implemented2 : Imsg
    {
        public void hello()
        {
            Console.WriteLine("Hello from another implemented class!");
        }
    }
}
