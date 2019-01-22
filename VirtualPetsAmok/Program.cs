using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pet Shelter!");
            Console.WriteLine("Type a word to continue: \n\n\t" +
                
                "E - Exit \n\t" +
                "P - View Pet \n\t" +
                "I - View Instructions" );
            Console.WriteLine("");
            string userInput = Console.ReadLine().ToLower();

            if (userInput.Equals("e"))
            {
                Console.WriteLine("Good-bye. Come again soon.");
                Environment.Exit(0);
            }
            else if (userInput.Equals("p"))
            {
                Console.WriteLine("Here's where the pet is");

            }

            Console.WriteLine("Patience Please!");
            
        }

    }
}
