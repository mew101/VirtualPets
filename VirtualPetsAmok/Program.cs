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
                
                Console.Write("\tType a LETTER to continue: \n\n\t" +

                    "E - Exit \n\t" +
                    "P - View Pets in Shelter \n\t" +
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
                    int petChoice = 0;
                    do
                    {
                        allPets.DisplayAllPets();
                        Console.WriteLine("\n\tChoose a pet: ");
                        petChoice = Convert.ToInt32(Console.ReadLine());

                        if ((petChoice > 0) && (petChoice <= allPets.GetNumPets()))
                        {
                            bool continueInteracting = true;
                            do
                            {
                                allPets.DisplayShelterPetInfo(petChoice);
                                continueInteracting = allPets.DisplayShelterPetInteractions(petChoice);
                            } while (continueInteracting);
                        }
                        else
                        {
                            //invalid choice
                            Console.WriteLine("Please choose a valid pet");
                        }
                    } while (petChoice != 0);

                    Console.ReadLine();
                    
                    
                    
                    
                    /*
                     * if (petExists)
                    {

                        pet1.DisplayPetInfo();
                        while (pet1.DisplayInteractionMenu())
                        {
                            pet1.TimeIncrement();
                            pet1.DisplayPetInfo();
                            if (!pet1.IsAlive())
                            {
                                Console.Clear();
                                Console.Beep();
                                pet1.PetDies();                               
                            }
                        }
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("We Don't have any pets yet.");
                        Console.WriteLine("Enter Y to create a Pet.");

                        if (Console.ReadLine().ToLower().Equals("y"))
                        {
                            pet1.SpecifyPet();
                            pet1.DisplayPetInfo();
                            //Console.WriteLine("How hungry is " + pet1.Name + " on a scale of 1 to 10 ? (10 being super FULL)");
                            //pet1.Fullness = System.Convert.ToInt32(Console.ReadLine());

                            petExists = true;

                           
                        }

                    }
                    */
                   

                }
                if ((petExists)&&(gameContinues))
                {
                    pet1.TimeIncrement();                 
                }
            } while (gameContinues);
            
            
        }
      
    }
}
