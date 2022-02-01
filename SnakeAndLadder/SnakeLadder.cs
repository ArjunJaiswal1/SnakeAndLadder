﻿using System;
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
        private Dictionary<int, int> dictLadders;
        private Dictionary<int, int> dictSnakes;
        private int NoOfTimesDiceRolled;



        public SnakeLadder()
        {
            objRandom = new Random();
            dictLadders = new Dictionary<int, int>()
            {
              {5, 1}, {11, 1}, {23, 1}, {44, 1}, {67, 1}, {82, 1}, {89, 1}
            };
            dictSnakes = new Dictionary<int, int>()
            {
              {12, 1}, {26, 1}, {35, 1}, {77, 1}, {84, 1}, {96, 1}, {99, 1}
            };
        }

        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position {0}", playerPosition);
            RollADie();
            while (true)
            {
                RollADie();
                if (playerPosition > 100)
                {
                    playerPosition = playerPosition - DieRolled;
                }
                Console.WriteLine("PlayerPosition: {0}", playerPosition);
                CheckOptions();
                if (CheckWinner());
                {
                    Console.WriteLine("No of times dice rolled {0}", NoOfTimesDiceRolled);
                    Console.WriteLine("Player Won");
                    break;
                }
            }
        }

        private void RollADie()
        {
           
            DieRolled = objRandom.Next(7);
            Console.WriteLine("Dice Rolled: {0}", DieRolled);
            playerPosition = playerPosition + DieRolled;
            Console.WriteLine("Player Position: {0}", playerPosition);
        }
        private void CheckOptions()
        {
            int ladder, snakeBite;
            dictLadders.TryGetValue(playerPosition, out ladder);
            if (ladder > 0)
            {
                Console.WriteLine("ladder: +{0}", DieRolled);
                playerPosition = playerPosition + DieRolled;
            }
            Console.WriteLine("Player Position: {0}", playerPosition);
            dictSnakes.TryGetValue(playerPosition, out snakeBite);
            if (snakeBite > 0)
            {
                Console.WriteLine("Snake Bite: -{0}", DieRolled);
                playerPosition = playerPosition - DieRolled;
            }
            Console.WriteLine("Player Position: {0}", playerPosition);
        }
        private bool CheckWinner()
        {
            if (playerPosition > 100)
            {
                playerPosition = playerPosition - DieRolled;
            }
            if (playerPosition == 100)
            { 
                Console.WriteLine("Player Won");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
    


    

