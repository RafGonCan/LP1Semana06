using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy [] enemyName = new Enemy[Convert.ToInt32(args[0])];

            for (int num = 0; num < Convert.ToInt32(args[0]); num++)
            {
                Console.Write($"Nome do inimigo {num +1}: ");
                enemyName[num] = new Enemy(Console.ReadLine());
            }
            foreach (Enemy name in enemyName)
            {
                Console.WriteLine($"{name.GetName()} {name.GetHealth()} {name.GetShield()}");
            }
        }
    }
}
