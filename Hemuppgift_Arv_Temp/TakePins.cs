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

        // D4. Frågan är vad vi har vunnit på att använda oss av arv från superklassen Player,
        // Jag tänker att vi har skapet huvudstrukturen med Player klassen och vad den skall ärva.
        // Vilket gör att subklasserna ärver det så vi slipper koda det i varje block. 

        // En abstract metod gör så att metoden är deklarerad i huvudklassen, så när man skapar 
        // subklassen så finns metoden med, man måste bara implementera hur man vill använda den.

        static void Main(string[] args)
        {

            // Skapa en board med ett antal önskade stickor (20 i detta exempel)
            Board board = new Board(20);

            // Skapa en HumanPlayer
            HumanPlayer human = new HumanPlayer("Human");

            // Välja mellan ComputerPlayer eller SmartComputerPlayer
            Console.WriteLine("Välj alternativ du vill spela mot (1: ComputerPlayer, 2: SmartComputerPlayer):");
            string choice = Console.ReadLine();

            Player computer;

            if (choice == "2")
            {
                computer = new SmartComputerPlayer("SmartComputerPlayer"); 
            }

            else
            {
                computer = new ComputerPlayer("ComputerPlayer");
            }

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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue; // Återgå till början av loopen om det blev fel
                }

                // Kontrollera om spelet är slut
                if (board.IsGameOver())
                {
                    Console.WriteLine("Spelet är slut! HumanPlayer vann!");
                    break; // Avsluta loopen om spelet är över
                }

                // ComputerPlayer spelar
                try
                {
                    int computerPins = computer.TakePins(board);
                    Console.WriteLine($"{computer.GetUserId()} tog {computerPins} stickor.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue; // Återgå till början av loopen om det blev fel
                }

                // Kontrollera om spelet är över
                if (board.IsGameOver())
                {
                    Console.WriteLine($"Spelet är slut! {computer.GetUserId()} vann!");
                    break; // Avsluta loopen om spelet är över
                }
            }

            Console.Read();
        }
    }
}
