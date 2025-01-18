using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    public class Roll
    {
        public int[] RollDice(int numRolls) 
        {
            Random random = new Random();

            // This sets up an array of integers
             int[] numCount = new int[13];

            // this will loop until the amount of rolls the user input is complete
            for (int icount = 0; icount < numRolls; icount++)
            {
                // Simulate rolling two 6-sided dice
                int die1 = random.Next(1, 7); // Random number between 1 and 6
                int die2 = random.Next(1, 7); // Random number between 1 and 6
                int sum = die1 + die2;

                //this will add the sum to the numCount array
                numCount[sum]++;

            }

            // this will return the array with the each number that was rolled
            return numCount;
        }
    }
}
