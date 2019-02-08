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

            OrganicPet pet1 = new OrganicPet("Kitty", "Rob", 4);    //This may need to be removed
            bool gameContinues = true;
            bool petExists = false;//probably remove

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
                    "\tA - Add a Pet            \n" +
                    "\tP - View Pets in Shelter \n" +
                    "\tI - View Instructions    \n" +
                    "\tE - Exit                 \n\n");
                
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
                    int petChoice = 0;
                    do
                    {

                        allPets.DisplayAllPetsZ();
                        Console.Write("\n\tChoose a pet: ");

                        //petChoice = Convert.ToInt32(Console.ReadLine());
                        string petChoiceString = Console.ReadLine();
                        if (char.IsNumber(petChoiceString[0]) && petChoiceString.Length==1)
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
                                allPets.DisplayShelterPetInfo(petChoice);
                                continueInteracting = allPets.DisplayShelterPetInteractions(petChoice);
                                allPets.TimePasses();
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
                else if (userInput.Equals("a"))
                {
                    Console.WriteLine("Add a Pet...");
                    Console.WriteLine("Which type of Pet?");
                    Console.WriteLine("\t1. Organic");
                    Console.WriteLine("\t2. Robotic");
                    int petType = Convert.ToInt32(Console.ReadLine());
                    
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

                }
                else if (userInput.Equals("i"))
                {

                }
                else
                {
                    Console.WriteLine("Please choose a valid option!");
                    Console.WriteLine("...Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                if ((petExists)&&(gameContinues))
                {
                    pet1.TimeIncrement();                 
                }
            } while (gameContinues);
            
            
        }
        //public static bool isDigit(string temp)
    }
}
