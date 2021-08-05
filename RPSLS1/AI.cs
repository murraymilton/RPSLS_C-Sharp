using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS1
{
    public class AI
    {
        string[] AInames = { "Ashtosva Netsar ", "Jaderigo Cudgorb", "Breliz Cotbar", "Rubkari Horred", "Zacmis Furmey", "Airiam" };

        //Create AI Player name
        Random rand = new Random();
        int index = Random.Next(AInames.Length);
        public AI()
        {
            Console.WriteLine(this.name = $"{AInames[index]} "); 
        }

        public override Gesture SelectGesture()
        {
            Random random = new Random();
            int randomIndex = random.Next(gestureOptions.Length);
            Gesture SelectedGesture = gestureOptions[randomIndex];
            this.gesture = new Gesture(SelectedGesture.name, SelectedGesture.wins, SelectedGesture.chosenGesture);
            return gesture;
        }
    }
}
