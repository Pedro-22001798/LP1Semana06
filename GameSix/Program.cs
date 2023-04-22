using System;

namespace GameSix // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static Foe[] enemies;
        static void Main(string[] args)
        {
            Console.WriteLine("How many enemies do you want to create?");
            int numEnemies = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numEnemies; i++)
            {
                Console.WriteLine($"What is the name of the enemy number {numEnemies}");
                string foeName = Console.ReadLine();
                Foe newEnemy = new Foe(foeName);
                enemies[numEnemies] = newEnemy;
            }

            Console.WriteLine("Obrigado por ter usado o programa!");   
            Console.WriteLine("Merci d'utiliser ce programme!");  
        }
    }
}