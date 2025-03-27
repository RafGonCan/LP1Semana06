using System;
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
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }
        
        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                
                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public string SetName(string newEnemyName)
        {
            string name = newEnemyName;
            int legthName = name.Length;

            if (legthName > 8)
            {
                name = name.Substring(0, 8);
            }
            return name;
        }
    }
}