using System;
namespace Bikita_4_heirarchical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game g = new gOne();
            Game g1 = new gTwo();
            Console.WriteLine(g.GameName());
            Console.WriteLine(g1.GameName());
            Console.ReadLine();
        }
    }
    public class Game
    {
        public virtual string GameName()
        {
            return "Football";
        }
    }
    public class gOne : Game
    {
        public override string GameName()
        {
            return "Basketbal";
        }
    }
    public class gTwo : Game
    {
        public override string GameName()
        {
            return "Volleyball";
        }
    }
}

