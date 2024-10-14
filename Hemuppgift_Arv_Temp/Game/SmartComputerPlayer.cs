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
        }


    }
}
