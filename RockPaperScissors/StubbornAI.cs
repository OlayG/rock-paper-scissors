using System;

namespace RockPaperScissors
{
    internal class StubbornAI : IPlayer
    {
        int SameMove;
        public StubbornAI(int favoriteMove)
        {
            SameMove = favoriteMove;
        }
        public int NextMove()
        {
            return SameMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {            
        }
    }
}