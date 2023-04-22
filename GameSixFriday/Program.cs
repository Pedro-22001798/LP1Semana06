using System;

namespace GameSixFriday
{
    public class Program
    {
        private static void Main()
        {
            GameLevel gl = new GameLevel(15, Difficulty.Hard);

            gl.SetFoeInRoom(2, new Foe("Darth Vader"));
            gl.SetFoeInRoom(5, new Foe("Borg Queen"));
            gl.SetFoeInRoom(11, new Foe("Thanos"));
            gl.SetFoeInRoom(12, new Foe("Xenomorph"));

            Console.WriteLine($"Difficulty: {gl.GetDifficulty()}");

            Console.WriteLine($"Number of rooms: {gl.GetNumRooms()}");

            Console.WriteLine($"Number of foes: {gl.GetNumFoes()}");

            gl.PrintFoes();

            // Este programa mostra o seguinte no ecrã:
            //
            // Difficulty: Hard
            // Number of rooms: 15
            // Number of foes: 4
            // Room 2: Darth Vader
            // Room 5: Borg Queen
            // Room 11: Thanos
            // Room 12: Xenomorph
        }
    }

    public class GameLevel
    {
        int rooms;
        Difficulty difficulty;
        Foe[] allFoes;
        public GameLevel(int numRooms, Difficulty gameDifficulty)
        {
            this.rooms = numRooms;
            this.difficulty = gameDifficulty;
            allFoes = new Foe[numRooms];
        }

        public void SetFoeInRoom(int room, Foe newFoe)
        {
            if(room <= rooms && room >= 0)
            {
                if(allFoes[room] == null)
                {
                    allFoes[room] = newFoe;
                }
                else
                {
                    Console.WriteLine("Room already has a Foe in it.");
                }
            }
        }

        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return rooms;
        }

        public int GetNumFoes()
        {
            int numFoes = 0;
            for(int i = 0; i < allFoes.Length; i++)
            {
                if(allFoes[i] != null)
                {
                    numFoes++;
                }
            }
            return numFoes;
        }

        public void PrintFoes()
        {
            for(int i = 0; i < allFoes.Length; i ++)
            {
                if(allFoes[i] != null)
                {
                    Console.WriteLine($"Room {i}: {allFoes[i].GetName()}");
                }
            }
        }
    }
}
