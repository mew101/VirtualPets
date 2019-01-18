using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pet Shelter!");
            Console.WriteLine("You will choose a pet later.");
            Console.WriteLine("Press 0 to Exit");
            string userInput = Console.ReadLine();

            if (userInput.Equals("0"))
            {
                Console.WriteLine("Good-bye. Come again soon.");
                Environment.Exit(0);
                
            }

             Console.WriteLine("Patience Please!");
            
        }

    }
}
