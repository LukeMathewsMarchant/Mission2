using System; 
//Luke Marchant
// A simple console application that allows you to simulate a number of dice rolls and then prints out a histogram
// As a visual representation of the results

namespace ConsoleApp1  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            
            Console.Write("How many dice rolls would you like to simulate? ");
            
            //Get User input for the number of rolls 
            int numRolls = int.Parse(Console.ReadLine());
                    
            // Create an instance of the DiceRolls class
            DiceRolls diceRoller = new DiceRolls();
                    
            // Call the method to simulate the rolls and get the results array back
            int[] results = diceRoller.SimulateRolls(numRolls); 
                    
            // Print the histogram
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.\n");
                    
            // Loop through possible sums (2 through 12)
            for (int sum = 2; sum <= 12; sum++)
            {
                // Calculate the percentage for this sum (cast to double and multiply by 100)
                double percentage = (results[sum] / (double)numRolls) * 100;
                        
                // Calculate how many asterisks you need
                int numAsterisks = (int)Math.Round(percentage);
                
                // Create the histogram with *
                string bar = new string('*', numAsterisks);
                        
                // Print the sum, count, and histogram
                Console.WriteLine($"{sum,2}: {bar}");
            }
                    
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}