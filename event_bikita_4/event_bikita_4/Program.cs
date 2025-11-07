using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_bikita_4
{
    public delegate void DelEventHandler();
    internal class Program
    {
        public event DelEventHandler add;
        public Program()
        {
            add = new DelEventHandler(Initialize);
            add();
        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
        private void Initialize()
        {
            Console.WriteLine("Event Initialized");
        }
    }
}
