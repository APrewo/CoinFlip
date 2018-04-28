using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class CoinFlip
    {
        static void Main(string[] args)
        {
            int numFlips = -1;

            while (numFlips != 0)
            {
                System.Console.Write("How many times would you like to flip a coin? ");
                while(Console.ReadLine()!=null)
                numFlips = Math.Abs(Int32.Parse(Console.ReadLine()));
                flipCoin(numFlips);
                System.Console.WriteLine("\n");
            }
        }

        private static void flipCoin(int numFlips)
        {
            int headCount = 0;
            int tailCount = 0;

            Random rng = new Random();
            for (int i = 0; i < numFlips; i++)
            {
                int headsOrTails = rng.Next(2);
                if (headsOrTails == 0)
                {
                    System.Console.Write("Heads ");
                    headCount++;
                }
                else if (headsOrTails == 1)
                {
                    System.Console.Write("Tails ");
                    tailCount++;
                }
            }
            if(numFlips!=0)
            System.Console.Write("\nHeads: {0}  Tails: {1}", headCount, tailCount);

        }
    }
}
