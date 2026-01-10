using System;

namespace ConsoleApp1
{
    public class Task3
    {
        public static void RunTask()
        {
            Console.WriteLine("--- Executing Task 3: Number Search ---");

            // Step 2: Declare and initialize an array
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            // Step 3: Ask the user for input
            Console.Write("Enter a number to search for: ");
            string input = Console.ReadLine();
            
            // Converting the string input to an integer
            bool isNumber = int.TryParse(input, out int target);

            if (isNumber)
            {
                Console.WriteLine($"Searching for {target}...");

                // Flag to track if the number was found
                bool found = false;

                // Step 4: Use a for loop to go through the array elements
                for (int i = 0; i < numbers.Length; i++)
                {
                    // Step 5: Inside the loop, compare user input to each element
                    if (numbers[i] == target)
                    {
                        // If a match is found:
                        Console.WriteLine($"Number found at position {i}!");
                        found = true;

                        // Use the break statement to stop the loop immediately
                        break;
                    }
                }

                // If the loop completes with no match, print "Number not found in the list."
                if (!found)
                {
                    Console.WriteLine("Number not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
            }
            
            Console.WriteLine("--- Task 3 execution complete. ---");
        }
    }
}