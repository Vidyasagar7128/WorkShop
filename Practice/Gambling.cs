using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Gambling
    {
        int total = 100;
        int bet = 1;
        int betTime = 0;
        
        public void Bet()
        {
            while (total!=0)
            {
                betTime++; 
                int random = new Random().Next(2);
                if (random == 0)
                {
                    total = total + bet;
                    Console.WriteLine(total);
                }
                else
                {
                    total = total - bet;
                    Console.WriteLine(total);
                }
                if (total == 50)
                    break;
                if (total == 150)
                    break;
                if (total == 0)
                    Console.WriteLine("No Money");
            }
        }
        public void LoseWin()
        {

            Console.WriteLine($"Todays Amount: {total}");
            Console.WriteLine($"Bet: {betTime} Times");

        }
    }
}
