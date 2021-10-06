using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Gambling
    {
        int total = 100;
        int bet = 1;
        
        public void Machine()
        {
            while (total!=0)
            {
                int random = new Random().Next(2);
                if (random == 0)
                    total = total + 1;
                else
                    total = total - 1;
                if (total == 0)
                {
                    Console.WriteLine("No Money");
                }
            }
        }
    }
}
