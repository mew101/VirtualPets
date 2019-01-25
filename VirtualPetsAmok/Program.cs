using System;


namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(124, 40);
            Console.BackgroundColor = ConsoleColor.DarkBlue; //Change Console background color 

            //VirtualPet[] pet1 = new VirtualPet[2];
            VirtualPet pet1 = new VirtualPet();    //This may need to be moved
            bool gameContinues = true;
            bool petExists = false;

            VirtualPet.Kitty(10,100); //Kitty(tabs, milliseconds);
            Console.WriteLine("Welcome to the Pet Shelter!");

            Console.BackgroundColor = ConsoleColor.Black; //Change console background color back to black
            do
            {
                
                Console.Write("Type a LETTER to continue: \n\n\t" +

                    "E - Exit \n\t" +
                    "P - View Pet \n\t" +
                    "I - View Instructions");
                Console.WriteLine("");
                
                string userInput = Console.ReadLine().ToLower();
                Console.Clear();
                if (userInput.Equals("e"))
                {
                    Console.WriteLine("Good-bye. Come again soon.");
                    //Environment.Exit(0);
                    gameContinues = false;
                }
                else if (userInput.Equals("p"))
                {
                    if (petExists)
                    {

                        pet1.DisplayPetInfo();
                        while (pet1.DisplayInteractionMenu())
                        { pet1.DisplayPetInfo(); }

                    }
                    else
                    {
                        Console.WriteLine("We Don't have any pets yet.");
                        Console.WriteLine("Enter Y to create a Pet.");

                        if (Console.ReadLine().ToLower().Equals("y"))
                        {


                            Console.Write("\n\tEnter the pet's species:");
                            pet1.Species = Console.ReadLine();
                            Console.Write("\n\tEnter the pet's name:");
                            pet1.Name = Console.ReadLine();

                            Console.Write("Congratulations! Your pet's name is " + pet1.Name +
                                "\nWhat is " + pet1.Name + "'s age? ");
                            //Console.WriteLine("\n\tEnter the pet's age:");
                            pet1.Age = System.Convert.ToInt32(Console.ReadLine());
                            pet1.DisplayPetInfo();
                            //Console.WriteLine("How hungry is " + pet1.Name + " on a scale of 1 to 10 ? (10 being super FULL)");
                            //pet1.Fullness = System.Convert.ToInt32(Console.ReadLine());

                            petExists = true;

                           
                        }

                    }
                    //Console.WriteLine("Here's where the pet is");

                }
                if ((petExists)&&(gameContinues))
                {
                    pet1.TimeIncrement();
                    Console.Beep();
                }
            } while (gameContinues);
            
            
        }
       /***
        public static void DisplayPetInfo(VirtualPet petty)
        {
            Console.WriteLine("\n\tYour pet is a " + petty.Species + ".");
            Console.WriteLine("\n\tYour pet's name is: " + petty.Name);
            Console.WriteLine("\n\tYour pet's age is: " + petty.Age);
            Console.Write("\n\tYour pet's fullness level is: ");
            VirtualPet.PrintStatusBar(petty.Fullness, 2);
            Console.Write("\n\tYour pet's happiness level is: ");
            VirtualPet.PrintStatusBar(petty.Happiness, 2);
            Console.Write("\n\tYour pet's energy level is: ");
            VirtualPet.PrintStatusBar(petty.Energy, 2);

        }***/
    }
}
