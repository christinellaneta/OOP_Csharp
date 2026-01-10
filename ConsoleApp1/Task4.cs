using System;

namespace ConsoleApp1
{
    public class Task4
    {
        public static void RunTask()
        {
            // 4. Use while loop to repeat the program until user presses “N”
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\nPress any following key to perform an arithmetic operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");

                // Get User Choice
                string choice = Console.ReadLine();

                // Input Handling for Values
                Console.Write("Enter Value 1: ");
                if (!double.TryParse(Console.ReadLine(), out double val1)) 
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                Console.Write("Enter Value 2: ");
                if (!double.TryParse(Console.ReadLine(), out double val2))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                // 3. Use switch-case structure to select user choice
                switch (choice)
                {
                    case "1":
                        Add(val1, val2);
                        break;
                    case "2":
                        Subtract(val1, val2);
                        break;
                    case "3":
                        Multiply(val1, val2);
                        break;
                    case "4":
                        Divide(val1, val2);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

                // 7. Prompt to continue or exit (Handles Y/N and y/n)
                Console.Write("Do you want to continue again (Y/N)? ");
                string response = Console.ReadLine()?.Trim().ToUpper();

                if (response == "N")
                {
                    continueProgram = false;
                }
            }
        }

        // 2. Use separate methods for +, –, *, /
        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public static void Divide(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}