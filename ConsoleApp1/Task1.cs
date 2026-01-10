using System;

namespace ConsoleApp1
{
    public class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kamusta, Mundo!");
            
            Console.WriteLine("\n--- Preparing to execute Tasks... ---");
            Task2.RunTask(); 
            Task3.RunTask();
            Task4.RunTask();
            
            Console.WriteLine("\n--- All tasks completed. ---");
        }
    }
}