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

                Console.WriteLine("Type a LETTER to continue: \n\n\t" +

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
                    Console.Clear();
                    if (petExists)
                    {
                        
                        Console.WriteLine("\n\tYour pet is a " + pet1.Species + ".");
                        Console.WriteLine("\n\tYour pet's name is: " + pet1.Name);
                        Console.WriteLine("\n\tYour pet's age is: " + pet1.Age);
                        Console.Write("\n\tYour pet's fullness level is: ");
                        PrintStatusBar(pet1.Fullness,2);
                        Console.Write("\n\tYour pet's happiness level is: "); 
                        PrintStatusBar(pet1.Happiness,2);
                        Console.Write("\n\tYour pet's energy level is: ");
                        PrintStatusBar(pet1.Energy,2);
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("Choose an action from the menu");
                        Console.WriteLine("F - Feed");
                        Console.WriteLine("P - Play");
                        Console.WriteLine("N - Nap");
                        Console.WriteLine("E - Go Back to Main Menu");
                        Console.Write("Entry.........: ");
                        string entry = Console.ReadLine();
                        switch (entry.ToLower())
                        {
                            case "f":
                                pet1.Feed();
                                break;
                            case "p":
                                pet1.Play();
                                break;
                            case "n":
                                pet1.Nap();
                                break;
                            default:
                                
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("We Don't have any pets yet.");
                        Console.WriteLine("Enter Y to create a Pet.");

                        if (Console.ReadLine().ToLower().Equals("y"))
                        {


                            Console.WriteLine("\n\tEnter the pet's species:");
                            pet1.Species = Console.ReadLine();
                            Console.WriteLine("\n\tEnter the pet's name:");
                            pet1.Name = Console.ReadLine();

                            Console.WriteLine("Congratulations! Your pet's name is " + pet1.Name +
                                "\nWhat is " + pet1.Name + "'s age? ");
                            //Console.WriteLine("\n\tEnter the pet's age:");
                            pet1.Age = System.Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n\tYour pet's age is: " + pet1.Age);
                            Console.WriteLine("\n\tYour pet's fullness level is: " + pet1.Fullness);
                            Console.WriteLine("\n\tYour pet's happiness level is: " + pet1.Happiness);
                            Console.WriteLine("\n\tYour pet's energy level is: " + pet1.Energy);
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

        public static void PrintStatusBar(int howMuch, int spaceMult)
        {
            //ConsoleColor currentBackground = Console.BackgroundColor;
            //ConsoleColor currentForeground = Console.ForegroundColor;

            //max is the number which will show 100% full bar
            int max = 10;
            //spaceMult is how many "blocks" per 1 unit, this is just for readability & aesthetics
            //int spaceMult = 2;

            Console.ForegroundColor = ConsoleColor.DarkBlue; //make font color easier to read inside bar
            //3 Color Scale: Green, Yellow, Red

            if (howMuch > ((2.0 / 3.0) * (double)max))//If number is between MAX and 2/3 of MAX
            {
                //Console.WriteLine("1st if green");
                Console.BackgroundColor = ConsoleColor.Green;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            else if (howMuch > ((1.0 / 3.0) * (double)max))//If number is < 2/3 and > 1/3 of MAX
            {
                //Console.WriteLine("2nd if yellow");
                Console.BackgroundColor = ConsoleColor.Yellow;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            else //If number is less than 1/3 of MAX
            {
                //Console.WriteLine("3rd if red");
                Console.BackgroundColor = ConsoleColor.Red;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            if (howMuch > 99)
                Console.Write("\b\b");// Add 2 extra backspaces in case number is 3 digits
            else if (howMuch > 9)
                Console.Write("\b");// Add 1 extra backspace in case number is 2 digits

            Console.Write("\b" + howMuch + "\n");
            Console.ResetColor();
        }
    }
}
