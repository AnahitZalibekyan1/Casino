using Casino2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHOOSE THE GAME");
            Console.WriteLine();
            Game game = null;

            while (true)
            {
                Console.WriteLine("1.Slot Machine\n2.Blackjack\n3.Exit");

                int x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    game = new SlotMachine("Slot Machine");
                }
                else if (x == 2)
                {
                    game = new Blackjack("Blackjack");
                }
                else if (x == 3)
                {
                    break;
                }

                game.Play();
            }
        }
    }
}
