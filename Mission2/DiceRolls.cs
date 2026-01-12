namespace ConsoleApp1;
//Luke Marchant
// A simple console application that allows you to simulate a number of dice rolls and then prints out a histogram
// As a visual representation of the results

    class DiceRolls
    {
        // Random number generator for dice rolls
        private Random random;
        
        public DiceRolls()
        {
            // Initialize the Random object
            random = new Random();
        }
        
        // Method to simulate rolling two dice multiple times
        public int[] SimulateRolls(int numRolls)
        {
            // Create an array to store counts for each sum (index 0-12, but only 2-12 are used)
            int[] rollCounts = new int[13]; // Indices 2-12 will store the counts
            
            // Loop for the number of rolls specified
            for (int i = 0; i < numRolls; i++)
            {
                // Roll the first die (1-6)
                int die1 = random.Next(1, 7); // Random number between 1 and 6
                
                // Roll the second die (1-6)
                int die2 = random.Next(1, 7); // Random number between 1 and 6
                
                // Calculate the sum of the two dice
                int sum = die1 + die2;
                
                // Increment the count for this sum in the array
                rollCounts[sum] += 1;
            }
            
            // Return the array containing the counts
            return rollCounts;
        }
    }
