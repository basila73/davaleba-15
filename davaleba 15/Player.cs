using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_15
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsActive { get; set; }

        public Player(string name, int score, bool isActive)
        {
            Name = name;
            Score = score;
            IsActive = isActive;
        }

    }
    
}

