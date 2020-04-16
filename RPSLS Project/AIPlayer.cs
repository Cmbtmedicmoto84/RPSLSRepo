using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class AIPlayer : Player
    {
        string[] whatGesture;

        public AIPlayer()
        {

        }

        public void AddWhatGesture()
        {
            whatGesture[0] = "";
            whatGesture[1] = "";
            whatGesture[2] = "";
            whatGesture[3] = "";

            foreach (string item in whatGesture)
            {
                Console.WriteLine(item);
            }
        }

    }
}
