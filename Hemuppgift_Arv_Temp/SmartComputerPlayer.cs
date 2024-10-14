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
            int numberOfPins;
            int remainingPins = board.GetNoPins();

            if (remainingPins <= 3)
            {
                numberOfPins = remainingPins; // Ta alla om det är 3 eller mindre.
            }
            else
            {
                numberOfPins = (remainingPins - 3) % 3;
                if (numberOfPins == 0) numberOfPins = 1;
            }

            return board.TakePins(numberOfPins);


        }
    }

    
}
