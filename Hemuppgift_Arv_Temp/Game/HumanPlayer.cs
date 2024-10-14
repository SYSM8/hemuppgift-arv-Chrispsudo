using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        // Konstruktor för att ställa in userId. 

        public HumanPlayer(string userId) : base(userId)
        {

        }

        // Implementering av TakePins för HumanPlayer.

        public override int TakePins(Board board)
        {
            Console.WriteLine("Ange hur många stickor du vill ta (1 eller 2):");
            int numberOfPins = int.Parse(Console.ReadLine());

            //Ta stickor från board. 

            return board.TakePins(numberOfPins);
        }

    }
}
