using System;

namespace ConsoleApp1
{
    public class Task5
    {
        public static void RunTask()
        {
            Console.WriteLine("Press any following key");
            Console.Write("Enter Total Students : ");
            
            // Input Robustness: Ensure total student count is a valid number
            if (!int.TryParse(Console.ReadLine(), out int totalCount) || totalCount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for students.");
                return;
            }

            // Performance Criteria: Multi-dimensional array to store all student data
            // Columns: [0] Name, [1] English, [2] Math, [3] Computer, [4] Total
            object[,] studentData = new object[totalCount, 5];

            // Input Iteration: Loop structure to prompt for marks for the specified total students
            for (int i = 0; i < totalCount; i++)
            {
                Console.Write("Enter Student Name : ");
                studentData[i, 0] = Console.ReadLine() ?? "Unknown";

                // Robust Input for Subjects (Check range 0-100)
                studentData[i, 1] = GetValidMark("English");
                studentData[i, 2] = GetValidMark("Math");
                studentData[i, 3] = GetValidMark("Computer");

                // Total Marks Calculation: Accurately calculate the sum
                int total = (int)studentData[i, 1] + (int)studentData[i, 2] + (int)studentData[i, 3];
                studentData[i, 4] = total;

                Console.WriteLine("*********************************************");
            }

            // Sorting Logic: Bubble Sort to sort by Total Marks in descending order
            for (int i = 0; i < totalCount - 1; i++)
            {
                for (int j = 0; j < totalCount - i - 1; j++)
                {
                    // Highest total comes first
                    if ((int)studentData[j, 4] < (int)studentData[j + 1, 4])
                    {
                        // Swap entire rows
                        for (int k = 0; k < 5; k++)
                        {
                            object temp = studentData[j, k];
                            studentData[j, k] = studentData[j + 1, k];
                            studentData[j + 1, k] = temp;
                        }
                    }
                }
            }

            // Output and Formatting
            Console.WriteLine("****************Report Card*******************");

            for (int i = 0; i < totalCount; i++)
            {
                Console.WriteLine("****************************************");
                // Position Assignment: Correctly assign rank based on sorted order
                Console.WriteLine($"Student Name: {studentData[i, 0]}, Position: {i + 1}, Total:");
                Console.WriteLine($"{studentData[i, 4]}/300");
            }
            Console.WriteLine("****************************************");
        }

        // Helper Method for Robust Input Handling
        private static int GetValidMark(string subject)
        {
            int mark;
            while (true)
            {
                Console.Write($"Enter {subject} Marks (Out Of 100) : ");
                if (int.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100)
                {
                    return mark;
                }
                Console.WriteLine("Invalid entry. Marks must be a number between 0 and 100.");
            }
        }
    }
}