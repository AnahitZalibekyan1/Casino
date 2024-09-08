using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
    internal abstract class Game
    {
        public string Name { get; protected set; }

        protected Game(string name)
        {
            Name = name;
        }

        public abstract void Play();

        protected void DisplayWelcomeMessage()
        {
            Console.WriteLine("WELCOME TO OUR GAME");
        }
    }
}
