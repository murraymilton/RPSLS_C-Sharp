using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS1
{
    class Gesture
    {
        public class Gesture
        {
            public string name;
            public string[] wins;
            public string[] chosenGesture;

            public Gesture(string name, string[]wins, string[] chosenGesture)
            {
                this.name = name;
                this.wins = wins;
                this.chosenGesture = chosenGesture;
            }
        }
    }
}
