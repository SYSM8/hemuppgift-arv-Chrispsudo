using Hemuppgift_Arv_Temp.Game;
using System.Security.Cryptography.X509Certificates;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen

        // F2 a, Superklass eller pappaklass? 
        // F2 b, Player p = new HumanPlayer("Alicent");
        //       HumanPlayer p = new ComputerPlayer("Aemond");


        static void Main(string[] args)
        {
            
            // Skapa en board med ett antal önskade stickor. 20 i mitt exempel.

            Board board = new Board(20);

            // Skapa en HumanPlayer och en ComputerPlayer.

            HumanPlayer human = new HumanPlayer("Human");

            ComputerPlayer computer = new ComputerPlayer("Computer");


            // Spelloopen

            while (!board.IsGameOver())
            {

                // HumanPlayer spelar

                try
                {
                    Console.WriteLine($"Det finns {board.GetNoPins()} stickor kvar.");
                    int humanPins = human.TakePins(board);
                    Console.WriteLine($"HumanPlayer tog {humanPins} stickor.");
                }
                // Fånga exception och börja om loopen om det blev fel.
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                // Kontrollera om spelet är slut.
                if (board.IsGameOver())
                {
                    Console.WriteLine("Spelet är slut! HumanPlayer vann!");
                    break;
                }

                // ComputerPlayer spelar

                try
                {

                }
                



        }

    }

        

    
}
