using System;
using System.Collections.Generic;

namespace PG.Duplicates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number to assess duplicates.");
            int.TryParse(Console.ReadLine(), out int _userInput);
            var service = new PG.Duplicates.Service.Duplicates();
            int[] dupes = service.findDuplicates(_userInput);
            var result = dupes == null ? "No duplicates found" : "Duplicates: " + string.Join(",", dupes);
            Console.WriteLine(result);
            Console.WriteLine("Please any enter to exit...");
            Console.ReadLine();
        }
    }
}
