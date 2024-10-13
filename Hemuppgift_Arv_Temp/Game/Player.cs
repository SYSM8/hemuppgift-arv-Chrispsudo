using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string Name { get; set; }

        protected Player(string name)
        {
            Name = name;
        }

        public abstract int TakePins(Board board);

    }
}
