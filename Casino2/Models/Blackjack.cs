using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2.Models
{
    class Blackjack : Game
    {
        private Random rand;

        public Blackjack(string name) : base("Blackjack")
        {
            Name = name;
            rand = new Random();
        }

        public override void Play()
        {
            DisplayWelcomeMessage();

            int player = rand.Next(16, 23);
            int dealer = rand.Next(16, 23);

            Console.WriteLine();
            Console.WriteLine($"{player}, {dealer}");

            if (player > 22 || dealer > 22)
            {
                Console.WriteLine("YOU LOSE");
            }

            else if (player > 22 && dealer > 22 || player == dealer)
            {
                Console.WriteLine("NICHYA");
            }

            else if (player > dealer)
            {
                Console.WriteLine("YOU WINN");
            }

            else if (dealer > player)
            {
                Console.WriteLine("THE DEALER WINN\nYOU LOSE");
            }
        }
    }
}
