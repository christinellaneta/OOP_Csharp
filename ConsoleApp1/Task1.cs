using System;

namespace ConsoleApp1
{
    public class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kamusta, Mundo!");
            
            Console.WriteLine("\n--- Preparing to execute Task 2 logic... ---");
            Task2.RunTask(); 
            
            Console.WriteLine("\n--- All tasks completed. ---");
        }
    }
}