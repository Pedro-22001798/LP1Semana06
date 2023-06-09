using System;

namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        private static int numPowerUps;

        static Foe()
        {
            numPowerUps = 0;
        }

        public Foe(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            string newName = name.Trim();
            this.name = newName;
        }

        public void PickUpPowerUp(PowerUp typeOfPowerUp, float quantity)
        {
            if(typeOfPowerUp == PowerUp.Health)
            {
                health = quantity;
                if(health > 100) health = 100;
                ++numPowerUps;
            }
            else if(typeOfPowerUp == PowerUp.Shield)
            {
                shield = quantity;
                if(shield > 100) shield = 100;
                ++numPowerUps;
            }
        }

        public static int GetNumPowerUps()
        {
            return numPowerUps;
        }
    }
}