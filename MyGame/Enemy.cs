using System;
using System.Runtime.CompilerServices;

namespace MyGame   
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int getPowerUp;

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

        static Enemy()
        {
            getPowerUp = 0;
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
        
        public void PickPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health += value;
                if (health > 100)
                {
                    health = 100;
                }
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += 100;
                if (shield > 100)
                {
                    shield = 100;
                }
            }
            getPowerUp ++;
        }

        public static int GetPowerUp()
        {
            return getPowerUp;
        }
    }
}