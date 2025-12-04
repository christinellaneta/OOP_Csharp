using System;

namespace ConsoleApp1
{
    public class Task2
    {
        public static void RunTask() 
        {
// Row 0: Even numbers
// Row 1: Odd numbers
            int[][] numberMatrix = new int[][]
            {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
            };  

            Console.WriteLine("The number matrix has been initialized.");
            Console.WriteLine();

            int digit1 = numberMatrix[1][3]; 
            int digit2 = numberMatrix[0][0];
            int digit3 = numberMatrix[1][4];

            string finalKeyString = $"{digit1}{digit2}{digit3}";

            Console.WriteLine($"Digit 1 extracted: {digit1}");
            Console.WriteLine($"Digit 2 extracted: {digit2}");
            Console.WriteLine($"Digit 3 extracted: {digit3}");

            Console.WriteLine();

            Console.WriteLine($"Final Key String: {finalKeyString}");

            Console.WriteLine("\n--- Displaying Full Array Contents: ---");

            for (int i = 0; i < numberMatrix.Length; i++) 
           {
                Console.Write($"Row {i}: ");
                
                // INNER LOOP: Iterates over the columns (numbers) in the current row.
                for (int j = 0; j < numberMatrix[i].Length; j++) 
                {
                    Console.Write(numberMatrix[i][j] + " ");
                }
                Console.WriteLine(); 
            }
            
            Console.WriteLine("\n--- Task 2 execution complete. ---");
            
        }
    }
}