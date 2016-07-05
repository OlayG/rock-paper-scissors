using System;

namespace RockPaperScissors
{
    internal class ThinkAheadAI : IPlayer
    {
        // (0 - R) : (1 - P) : (2 - S)
        // Instance of RandomAI class 
        RandomAI randomAI = new RandomAI();

        int enemyMove, firstGame = 0;

        public int NextMove()
        {
            int myMove;

            if (firstGame == 0)
            {
                myMove = randomAI.NextMove();
            }
            else if (enemyMove == 0)
            {
                myMove = 2;
            }
            else if (enemyMove == 1)
            {
                myMove = 0;
            }
            else if (enemyMove == 2)
            {
                myMove = 1;
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