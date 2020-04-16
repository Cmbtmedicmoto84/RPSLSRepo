using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class AIPlayer : Player
    {
        string gesture;
        int gestRoll;
        Random random = new Random();

        public AIPlayer()
        {
            
        }
        public override void Gesture()
        {

        }

        public void indRoll()
        {
            int gestRoll = random.Next(0, 4); //how do i get this to equal a usable result???
            Console.WriteLine();
            return;
        }
    }
}