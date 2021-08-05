using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS1
{
    public class Human
    {
        public void PlayerName()
        {
            Console.WriteLine("Enter your name:");
            namePlayer = Console.ReadLine();
        }

        public override Gesture PickGesture()
        {
            Gesture selected = new Gesture([]);
            Gesture gesture = selected;
            while (gesture == selected)
            {
                Console.WriteLine("{0}, select your gesture.", namePlayer);
            }
        }
    }
}
