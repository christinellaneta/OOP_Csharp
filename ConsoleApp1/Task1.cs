using System;

namespace ConsoleApp1
{
    // Task 1: This class contains the single application entry point (Main).
    public class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kamusta, Mundo!");
            
            // -----------------------------------------------------------------
            // Next Task Execution: Dispatching to the next class
            Console.WriteLine("\n--- Preparing to execute Task 2 logic... ---");
            Task2.RunTask(); 
            
            Console.WriteLine("\n--- All tasks completed. ---");
        }
    }
}