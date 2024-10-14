using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {   
        // Egenskap för att lagra userId.
        public string UserId { get; private set; }  // privat set för att skydda så att det inte ändras.

        // Konstruktor för att ställa in userId.

        public Player(string userId)
        {
            UserId = userId;
        }

        // Metod för att hämta in userId.

        public string GetUserId()
        {
            return UserId;
        }

        // Abstrakt metod för att ta stickor från ett Board-objekt.

        public abstract int TakePins(Board board);

    }
}
