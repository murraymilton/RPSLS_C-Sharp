using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS1
{
    public class GameDisplay
    {
        public Human playerOne = new Human();
        public AI playerTwo = new AI();


        public GameDisplay() 
        {
            Console.WriteLine($"Welcome ot Rock, Paper, Scisoors, Lizard, Spock!");
            Thread.Sleep(1000);
            Console.WriteLine($"Rules are simply just like Rock, Paper, Scissors. Just with the addition of 2 more options of lizard and spock.");
            Thread.Sleep(1000);
            Console.WriteLine($"Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
            Thread.Sleep(1000);
            Console.WriteLine($"Got it, good");
            Thread.Sleep(1000);
            Console.WriteLine($"For the number of players enter 1 to play against the AI, enter 2 to play against another human");
            Thread.Sleep(1000);
            Console.WriteLine($"when choosing a gesture hit a single number and hit enter the number that you have selected will not be displayed in terminal.");
            Thread.Sleep(1000);

        }

    }
}
