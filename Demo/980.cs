using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Game
    {
        public string Name { get; set; }
        public int MaxNumPlayers { get; set; }
        public override string ToString()
        {
            return "Maximum number of players for" + Name + "is" + MaxNumPlayers;
        }
    }
    class GameWithTimeLimit : Game
    {
        public int TimeLimit { get; set; }
        public override string ToString()
        {
            base.ToString();
            return "Time Limit for" + Name + "is" + TimeLimit + "minutes";
        }
    }
    class Program23
    {
        static void Main(string[] args)
        {
            Game G = new Game();
            GameWithTimeLimit G1 = new GameWithTimeLimit();
            Console.WriteLine("Enter a game");
            G.Name = Console.ReadLine();
            Console.WriteLine("Enter the maximum number of players");
            G.MaxNumPlayers = int.Parse(Console.ReadLine());
            string s1 = G.ToString();
            Console.WriteLine(s1);
            Console.WriteLine("Enter a game that has time limit");
            G.Name = Console.ReadLine();
            Console.WriteLine("Enter the maximum number of players");
            G.MaxNumPlayers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time limit in minutes");
            G1.TimeLimit = int.Parse(Console.ReadLine());
            string s = G1.ToString();
            Console.WriteLine(s);
            Console.Read();


        }
    }
}
