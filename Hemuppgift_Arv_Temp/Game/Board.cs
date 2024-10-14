using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    // Klassen Board. 
    public class Board
    {
        // Egenskap som lagrar antalet stickor.
        public int NoPins {  get; set; }

        // Konstruktor för att ställa in antalet stickor.

        public Board(int initialPins)
        {
            SetUp(initialPins);
        }

        // Metod för att ställa in stickorna.

        public void SetUp(int pins)
        {
            if (pins < 0)
                throw new ArgumentException("Antalet stickor kan inte vara negativt.");
            NoPins = pins;
        }

        // Metod för att ta stickor

        public int TakePins(int numberOfPins)
        {
            if ((numberOfPins < 1) || (numberOfPins > 2 || numberOfPins > NoPins))
            {
                throw new ArgumentException("Du kan ta 1 eller 2 stickor");
            }
            NoPins -= numberOfPins;
            return numberOfPins;
        }
        
        // Metod som returnerar antalet stickor som är kvar.

        public int GetNoPins() 
        { 
            return NoPins; 
        }

        // Metod som kollar om spelet är slut.
        public bool IsGameOver()
        {
            return NoPins <= 0;
        }


    }
}
