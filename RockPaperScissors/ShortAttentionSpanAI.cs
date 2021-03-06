﻿using System;

namespace RockPaperScissors
{
    internal class ShortAttentionSpanAI : IPlayer
    {
        // Instance of RandomAI class 
        RandomAI randomAI = new RandomAI();

        // keep track of enemies last move
        int enemyMove, firstGame = 0;

        public int NextMove()
        {
            // Variable for AI's move
            int myMove;
            
            if (firstGame == 0)
            {
                myMove = randomAI.NextMove();
            }
            else if (enemyMove == 0)
            {
                myMove = 1;
            }
            else if (enemyMove == 1)
            {
                myMove = 2;
            }
            else if (enemyMove == 2)
            {
                myMove = 0;
            }
            else
            {
                myMove = randomAI.NextMove();
            }

            return myMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            enemyMove = otherMove;
            firstGame = 1;
        }
    }
}