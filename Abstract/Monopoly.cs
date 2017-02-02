using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class Monopoly : Game
    {

        public Monopoly(int numberOfMonopolyPlayers)
            : base(numberOfMonopolyPlayers)
        {
        }

        private List<string> players;
        private Random rnd = new Random();
        private int numberOfPlayers;
        private int currentPlayer; 

        public override bool EndOfGame()
        {
            return players.Count == 1;
        }

        protected void InitializeGame()
        {
            players = new List<string>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                players.Add("Player " + i);
                Console.WriteLine("Player " + i + " joined the game and was given $1000");
            }

            Console.WriteLine();
        }

        public  void PrepareToPlay()
        {
            Console.WriteLine("The remaining player " + players[0] + " is the winner!");
            Console.WriteLine();
        }

        public void TakeTurn(int playerNumber)
        {
            //Randomly make a player get eliminated
            int random = rnd.Next(100);

            // Eliminate the player if the random number 
            // is divisible by 7
            if (random % 7 == 0)
            {
                Console.WriteLine();
                Console.Write("ELIMINATED  ------ ");
                Console.WriteLine(players[playerNumber] + " ran out of $ eliminated!");
                Console.WriteLine();

                // Remove player fromthe lineup
                players.RemoveAt(playerNumber);
                numberOfPlayers--;
                currentPlayer = currentPlayer - 1;
            }
            else //let them keep playing
            {
                Console.WriteLine(players[playerNumber] + " just took their turn");
            }
        }
    }
}
