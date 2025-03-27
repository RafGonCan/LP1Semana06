using System.Runtime.CompilerServices;

namespace MyGame   
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
        public string GetName()
        {
            return name;
        }
    }
}