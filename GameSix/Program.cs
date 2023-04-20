using System;

namespace GameSix // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
        }
    }

    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}