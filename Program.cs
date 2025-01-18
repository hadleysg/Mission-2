using System.Drawing;
using System.Threading.Tasks;
using Mission_2;

// Hadley Garff 4-14. 
// This program allows the user to enter in an amount of rolls for two dice. Then it will show a histogram for what numbers the user rolled.
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dice Rolling Simulator!");
        Console.Write("Enter the number of times to roll the dice: ");

        // Get user input for the number of rolls
        if (int.TryParse(Console.ReadLine(), out int rolls) && rolls > 0)
        {
            // Create an instance of the Roll class
            Roll roller = new Roll();
            int[] results = roller.RollDice(rolls);

            Console.WriteLine("\nHistogram of Dice Roll Percentages:"); Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}.\n");

            // Display the histogram
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (double)results[i] / rolls * 100;
                Console.Write($"{i}: ");

                // Print stars for the histogram
                int stars = (int)Math.Round(percentage); // Each * represents 1%
                Console.WriteLine(new string('*', stars));
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        // Ending words to user
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}