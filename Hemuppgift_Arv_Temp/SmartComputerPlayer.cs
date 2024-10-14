using Hemuppgift_Arv_Temp.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class SmartComputerPlayer : Player
    {
        public SmartComputerPlayer(string userId) : base(userId)
        {

        }

        public override int TakePins(Board board)
        {
            int remainingPins = board.GetNoPins();
            int numberOfPins;
            
            // Om det är 3 eller färre kvar, ta alla.
            if (remainingPins <= 2)
            {
                numberOfPins = remainingPins; 
            }
            else
            {   // Beräkna hur många stickor att lämna kvar för att maxa chansen att vinna.
                numberOfPins = (remainingPins - 2) % 2;
                if (numberOfPins == 0) numberOfPins = 1;
            }

            // Kontrollera så att den inte försöker ta mer än vad som finns kvar.

            if (numberOfPins > board.GetNoPins())
            {
                numberOfPins = board.GetNoPins(); // Justera till max som finns kvar. 
            }

            return board.TakePins(numberOfPins);


        }
    }

    
}
