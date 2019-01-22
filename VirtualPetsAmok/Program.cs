using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet pet1 = new VirtualPet();    //This may need to be moved

            bool petExists = false;

            Console.WriteLine("Welcome to the Pet Shelter!");

            do
            {

                Console.WriteLine("Type a LETTER to continue: \n\n\t" +

                    "E - Exit \n\t" +
                    "P - View Pet \n\t" +
                    "I - View Instructions");
                Console.WriteLine("");
                string userInput = Console.ReadLine().ToLower();

                if (userInput.Equals("e"))
                {
                    Console.WriteLine("Good-bye. Come again soon.");
                    Environment.Exit(0);
                }
                else if (userInput.Equals("p"))
                {
                    if (petExists)
                    {
                        Console.WriteLine("\n\tYour pet's name is: " + pet1.Name);
                        Console.WriteLine("\n\tYour pet's age is: " + pet1.Age);
                        Console.WriteLine("\n\tYour pet's hunger level is: " + pet1.Hunger);

                    }
                    else
                    {
                        Console.WriteLine("We Don't have any pets yet.");
                        Console.WriteLine("Enter Y to create a Pet.");

                        if (Console.ReadLine().ToLower().Equals("y"))
                        {


                            Console.WriteLine("\n\tEnter the pet's name:");
                            pet1.Name = Console.ReadLine();

                            Console.WriteLine("Congratulations! Your pet's name is " + pet1.Name +
                                "\nWhat is " + pet1.Name + "'s age? ");
                            //Console.WriteLine("\n\tEnter the pet's age:");
                            pet1.Age = System.Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("How hungry is " + pet1.Name + " on a scale of 1 to 10 ? (10 being super FULL)");
                            pet1.Hunger = System.Convert.ToInt32(Console.ReadLine());

                            petExists = true;

                           
                        }

                    }
                    //Console.WriteLine("Here's where the pet is");

                }
            } while (true);
            
            
        }

    }
}
