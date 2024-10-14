using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hemuppgift_Arv_Temp.Game
{
    public class SmartComputerPlayer : Player
    {
        // Konstruktor för att ställa in userId
        public SmartComputerPlayer(string userId) : base(userId)
        {
        }

        // Implementering av TakePins för SmartComputerPlayer
        public override int TakePins(Board board)
        {
            int numberOfPins;
            int remainingPins = board.GetNoPins();

            if (remainingPins <= 3)
            {
                numberOfPins = remainingPins; // Ta alla stickor om det är 3 eller färre.
            }
            else
            {
                numberOfPins = (remainingPins - 3) % 3; // Lämna 3 stickor 
                if (numberOfPins == 0) numberOfPins = 1; // Om det är 0, ta 1 sticka
            }

            return board.TakePins(numberOfPins);
        }
    }

}
