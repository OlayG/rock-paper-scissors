using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    internal class UnbeatableAI : IPlayer
    {
        // if male first move paper
        // if female first move rocks
        // inform user of move you want them to play
        // if they choose the same(paper) twice, they will probably pick rock or siss
        // beat last winning move
        // scissors is the least common gesture
        static int choice;

        List<int> enemyPicks = new List<int>();
        RandomAI randomPick = new RandomAI();
        int counter = 0;

        // (0 - R) : (1 - P) : (2 - S)
        int getNextMove()
        {
            int myMove;


            if (counter == 0)
            {
                if(choice == 1)
                {
                    return myMove = 2;  
                }
                else
                {
                    return myMove = 1;
                }
            }
            else if (counter > 0)
            {
                if (enemyPicks.Count > 1 && enemyPicks[enemyPicks.Count] == enemyPicks[enemyPicks.Count - 1])
                {
                    if (enemyPicks.Count == 0)
                    {
                        return myMove = 2;
                    }
                    else if (enemyPicks.Count == 1)
                    {
                        return myMove = 0;
                    }
                    else
                    {
                        return myMove = 1;
                    }
                    
                }
            }
            else
            {
                return randomPick.NextMove();
            }
            myMove = randomPick.NextMove();
            return myMove;
        }

        public void GameInstructions()
        {
            string maleFirstPick = "Paper";
            string femaleFirstPick = "Rock";

            Console.Write("Are you ready?\n");

            if (choice == 1)
            {
                //int countdown = 3;
                //while (countdown > 0)
                //{
                    Console.Clear();
                    Console.WriteLine("Don't Cheat! Remember the rules!");
                    //Console.WriteLine("{0}", countdown);
                    //countdown--;
                //}
                Console.WriteLine(maleFirstPick);
            }
            else if (choice == 0)
            {
                int countdown = 3;
                while (countdown > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Don't Cheat! Remember the rules!");
                    Console.WriteLine("{0}", countdown);
                    countdown--;
                }
                Console.WriteLine(femaleFirstPick);
            }
            else
            {

            }
        }

        public void getSex()
        {
            Console.WriteLine("What is your sex?\n1 for M & 2 for F");
            choice = Convert.ToInt32(Console.ReadLine());
            GameInstructions();
        }
        public int NextMove()
        {
            return getNextMove();
        }

        public void SaveResult(int myMove, int otherMove)
        {
            if (otherMove >= 0 && otherMove < 3)
            {
                enemyPicks.Add(otherMove);
                counter = 1;
            }
        }
    }
}