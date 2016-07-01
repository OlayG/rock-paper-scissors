using System;

namespace RockPaperScissors
{
    internal class RandomAI : IPlayer
    {
        // (0 - R) : (1 - P) : (2 - S)
        Random r = new Random();

        public int NextMove()
        {
            
           return getNextMove();
        }

        private int getNextMove()
        {
            return r.Next(3);
        }

        public void SaveResult(int myMove, int otherMove)
        {
            // This method left blank           
        }
    }
}