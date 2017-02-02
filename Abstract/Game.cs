using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class Game
    {

        private int numberOfPlayers;

        public Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }

        public void playOneGame()
        {
            prepareToPlay();
            for (int i = 0; !EndOfGame(); i = (i + 1) % numberOfPlayers)
            {
                makePlay(i);
            }
            displayWinner();
        }

        public virtual void prepareToPlay()
        {

        }

        public virtual bool EndOfGame() { return false; }

        public void makePlay(int player) { }

        public void displayWinner() { }
    }
}
