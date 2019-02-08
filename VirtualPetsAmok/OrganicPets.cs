using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class OrganicPet : VirtualPet
    {
        public int Fullness { get; set; }
        
        public OrganicPet(string s, string n, int a) : base(s, n, a)
        {
            //Species = s;
            //Name = n;
            //Age = a;
            //Energy = 5;
            Fullness = 5;
        }

        public override void TimeIncrement()
        {
            Console.Beep();
            Energy--;
            Happiness--;
            Fullness--;
        }

        public void Feed()
        {
            Fullness += IncreaseAmount;
            Console.Clear();
            Console.WriteLine("\tYou just FED " + Name + " !");
        }

        

        public override void DisplayPetInfo()
        {
            Console.Write("\n\tYour " + Species + ", " + Name + ", is " + Age + " years old.\n\n");

            Console.Write("\n\tFullness:  ");
            PrintStatusBar(Fullness, 2);
            Console.Write("\n\tHappiness: ");
            PrintStatusBar(Happiness, 2);
            Console.Write("\n\tEnergy:    ");
            PrintStatusBar(Energy, 2);
            Console.WriteLine("\n");
        }
        public void DisplayPetStats()
        {
            Console.Write("\tFullness:  ");
            PrintStatusBar(Fullness, 2);
            Console.Write("\tHappiness: ");
            PrintStatusBar(Happiness, 2);
            Console.Write("\tEnergy:    ");
            PrintStatusBar(Energy, 2);
            //Console.WriteLine("\n");
        }
        public bool DisplayInteractionMenu()
        {

            bool interacted = true;

            Console.WriteLine("\n_____________________________________________\n");

            Console.WriteLine("\n\tChoose an action from the menu:\n");
            Console.WriteLine("\tF - Feed ");
            Console.WriteLine("\tP - Play");
            Console.WriteLine("\tN - Nap");
            Console.WriteLine("\tE - Go Back to Shelter");
            Console.Write("\n\tEntry.........: ");
            string entry = Console.ReadLine();

            switch (entry.ToLower())
            {
                case "f":
                    Feed();
                    break;
                case "p":
                    Play();
                    break;
                case "n":
                    Nap();
                    break;
                default:
                    interacted = false;
                    break;
            }
            return (interacted);
        }
        public string GetPetInfo()
        {

            return (Species + " " + Name + " " + Age.ToString());
        }
        public string GetPetInfoFormatted()
        {
            string s = Species.PadRight(15);
            string n = Name.PadRight(15);
            string a = Age.ToString().PadRight(6);
            return (s+n+a);
        }
    }
}