using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    abstract class Player
    {
        public int score;
        public string whatGesture;
 
        public Player()
        {

        }

        public abstract void WhatGesture();
    }
}
