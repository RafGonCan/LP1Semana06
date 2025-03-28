using System;
using System.Data;
using Humanizer;

namespace MyRoguelike
{
    public class Program
    {
        private static void Main()
        {
            Level lvl = new Level(125, Toughness.Nightmare);

            lvl.SetEnemyInRoom(0, new Enemy("Urdnot Wrex"));
            lvl.SetEnemyInRoom(120, new Enemy("Commander Shepard"));
            lvl.SetEnemyInRoom(41, new Enemy("Liara T'Soni"));
            lvl.SetEnemyInRoom(13, new Enemy("Tali'Zorah"));
            lvl.SetEnemyInRoom(59, new Enemy("Garrus Vakarian"));
            lvl.SetEnemyInRoom(99, new Enemy("Joker"));

            Console.WriteLine($"Toughness: {lvl.GetToughness()}");

            Console.WriteLine($"Number of rooms: {lvl.GetNumRooms()}");

            Console.WriteLine($"Number of enemies: {lvl.GetNumEnemies()}");

            lvl.PrintEnemies();
        }
        public class Level
        {
            private int roomNum;
            private Thoughness thoughness;

            public Level(int roomNum, Thoughness thoughness)
            {
                this.roomNum = 0;
                this.thoughness = thoughness;
            }
            
        }
    }
}
