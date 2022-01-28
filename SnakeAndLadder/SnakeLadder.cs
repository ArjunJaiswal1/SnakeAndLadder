using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblems
{
    public class SnakeLadder
    {
        private int playerPosition;
        private Random objRandom;
        private int DieRolled;

        public SnakeLadder()
        {
            objRandom = new Random();
        }

        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position {0}", playerPosition);
            RollADie();
        }

        private void RollADie()
        {
            DieRolled = objRandom.Next(1, 7);
            Console.WriteLine("Dice Rolled: {0}", DieRolled);
            int PlayerPosition = 0;
            PlayerPosition = PlayerPosition + DieRolled;
            Console.WriteLine("Player Position: {0}", PlayerPosition);
        }
    }
} 
    

