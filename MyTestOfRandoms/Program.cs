using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to store user input
            int n;

            // Variable to store sum of thrown die
            int sum = 0;

            // Ask user for input
            Console.Write("Insert number of die to throw: ");

            // Store user input in variable
            n = Convert.ToInt32(Console.ReadLine());

            // Start loop until 'i' is equal to 'n'
            for (int i = 1; i <= n; i++)
            {
                // Initialize new variable of Random class
                Random rnd = new Random();

                // Add value of current dice to sum
                sum += rnd.Next(1, 6);
            }

            // Show sum of all thrown die
            Console.WriteLine($"Sum of all thrown die values: {sum}");
        }
    }
}
