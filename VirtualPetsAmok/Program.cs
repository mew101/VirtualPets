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
            Shelter allPets = new Shelter();

            //OrganicPet pet1 = new OrganicPet("Kitty", "Rob", 4);    //This may need to be removed
            bool gameContinues = true;
            //bool petExists = false;//probably remove

            OrganicPet.Kitty(10,100); //Kitty(tabs, milliseconds);
            Console.WriteLine("Welcome to the Pet Shelter!");

            Console.BackgroundColor = ConsoleColor.Black; //Change console background color back to black
            /*
            Shelter xxx = new Shelter();
            Console.Clear();
            xxx.DisplayAllPets();
            Console.ReadLine();
            */

            do
            {
                
                Console.Write("\tType a LETTER to continue:       \n\n" +
                    "\tG - Give a Pet Away for Adoption\n" +
                    "\tA - Add a Pet            \n" +
                    "\tP - View Pets in Shelter \n" +
                    "\tI - View Instructions    \n" +
                    "\tE - Exit                 \n\n");

                //string userInput = Console.ReadLine().ToLower();
                string userInput = Console.ReadLine();
                if ((userInput.Length > 1) || !(char.IsLetter(userInput[0])))   
                {
                    userInput = "x";
                }
                else
                {
                    userInput = userInput.ToLower();
                }

                Console.Clear();
                if (userInput.Equals("e"))
                {
                    Console.WriteLine("Good-bye. Come again soon.");
                    //Environment.Exit(0);
                    gameContinues = false;
                }
                else if (userInput.Equals("p"))
                {
                    if (allPets.HowManyPetsInShelter() > 0)
                    {
                        Console.Clear();
                        int petChoice = 0;
                        do
                        {

                            Console.Clear();
                            allPets.DisplayAllPetsZ();
                            Console.Write("\n\tChoose a pet (0 to Go Back): ");

                            //petChoice = Convert.ToInt32(Console.ReadLine());
                            string petChoiceString = Console.ReadLine();
                            if (char.IsNumber(petChoiceString[0]) && petChoiceString.Length == 1)
                            {
                                petChoice = Convert.ToInt32(petChoiceString);
                                //Console.WriteLine("petChoice: " + petChoice);
                            }
                            else
                            {
                                petChoice = -1;
                            }

                            if ((petChoice > 0) && (petChoice <= allPets.GetNumPets()))
                            {
                                bool continueInteracting = true;

                                do
                                {

                                    Console.Clear();
                                    allPets.DisplayShelterPetInfo(petChoice);
                                    continueInteracting = allPets.DisplayShelterPetInteractions(petChoice);
                                    if(continueInteracting) allPets.TimePasses();
                                    allPets.CheckForDeath();
                                    if (petChoice > allPets.HowManyPetsInShelter())
                                    {
                                        continueInteracting = false;
                                    }
                                } while (continueInteracting);
                            }
                            else
                            {
                                //invalid choice
                                Console.WriteLine("Please choose a valid pet");
                            }
                        } while (petChoice != 0);
                        //Console.ReadLine()
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The Shelter is EMPTY! (Hint: Add a Pet)");
                        Console.WriteLine("...Press any key to continue");
                        Console.ReadKey();
                    }
                }
                else if (userInput.Equals("a"))
                {
                    int petType = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Add a Pet...");
                        Console.WriteLine("Which type of Pet?");
                        Console.WriteLine("\t1. Organic");
                        Console.WriteLine("\t2. Robotic");

                        petType = 0;
                        string petChoiceString = Console.ReadLine();
                        if (char.IsNumber(petChoiceString[0]) && petChoiceString.Length == 1)
                        {
                            petType = Convert.ToInt32(petChoiceString);
                            //Console.WriteLine("petChoice: " + petChoice);
                        }
                        else
                        {
                            petType = -1;
                        }
                        switch (petType)
                        {
                            case 1:
                                allPets.CreateOrgPet();
                                break;
                            case 2:
                                allPets.CreateRoboPet();
                                break;
                            default:
                                Console.WriteLine("Choose Organic or Robotic");
                                break;
                        }
                    } while (!(petType >= 1 && petType <= 2));

                }
                else if (userInput.Equals("i"))
                {
                    Console.Clear();
                    Console.WriteLine("The Instructions are to keep pets alive!");
                    Console.WriteLine("...Press any key to continue");
                    Console.ReadKey();
                }
                else if (userInput.Equals("g"))
                {
                    if (allPets.HowManyPetsInShelter() > 0)
                    {
                        Console.Clear();
                        int petChoice = 0;
                        bool petWasRemoved = false;
                        do
                        {

                            allPets.DisplayAllPetsZ();
                            Console.WriteLine("Which Pet found a Permanent Home?");
                            Console.Write("\n\tChoose a pet: ");

                            //petChoice = Convert.ToInt32(Console.ReadLine());
                            string petChoiceString = Console.ReadLine();
                            if (char.IsNumber(petChoiceString[0]) && petChoiceString.Length == 1)
                            {
                                petChoice = Convert.ToInt32(petChoiceString);
                                //Console.WriteLine("petChoice: " + petChoice);
                            }
                            else
                            {
                                petChoice = -1;
                            }

                            if ((petChoice > 0) && (petChoice <= allPets.GetNumPets()))
                            {

                                allPets.RemoveAPet(petChoice);
                                petWasRemoved = true;
                                
                            }
                            else
                            {
                                //invalid choice
                                Console.WriteLine("Please choose a valid pet");
                            }
                        } while (petChoice != 0 && !petWasRemoved);
                        //Console.ReadLine()
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The Shelter is EMPTY! (Hint: Add a Pet)");
                        Console.WriteLine("...Press any key to continue");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("Please choose a valid option!");
                    Console.WriteLine("...Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.Clear();
            } while (gameContinues);
            
            
        }
        //public static bool isDigit(string temp)
    }
}
