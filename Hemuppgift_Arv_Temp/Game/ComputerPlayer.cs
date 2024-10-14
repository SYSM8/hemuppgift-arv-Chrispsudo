using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {

        // Konstruktor för att ställa in userId

        public ComputerPlayer(string userId) : base(userId) 
        {

        }

        // Implementering av TakePins för ComputerPlayer.

        public override int TakePins(Board board)
        {
            // Dator logik som tar ett random beslut.

            Random random = new Random();
            int numberOfPins = random.Next(1, 3);


            // Tar stickorna från board.

            return board.TakePins(numberOfPins);

        }

    }
    
}
