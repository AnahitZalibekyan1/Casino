using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2.Models
{
    class SlotMachine : Game
    {
        private Random rand;

        public SlotMachine(string name) : base("Slot Machine")
        {
            Name = name;
            rand = new Random();
        }

        public override void Play()
        {
            DisplayWelcomeMessage();
            int rnd1 = rand.Next(1, 4);
            int rnd2 = rand.Next(1, 4);
            int rnd3 = rand.Next(1, 4);

            Console.WriteLine();
            Console.WriteLine($"{rnd1}, {rnd2}, {rnd3}");


            if (rnd1 == rnd2 && rnd1 == rnd3 && rnd2 == rnd3)
            {
                Console.WriteLine("YOU WINN!!!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("YOU LOSE");
                Console.WriteLine();
            }
        }
    }
}
