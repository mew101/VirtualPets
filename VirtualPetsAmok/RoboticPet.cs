using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class RoboticPet : VirtualPet
    {
        public int Lubricity { get; set; }

        public RoboticPet(string s, string n, int a) : base(s, n, a)
        {
            //Species = s;
            //Name = n;
            //Age = a;
            Energy = 5;  //battery level
            Lubricity = 5;
            
        }
        public override void TimeIncrement()
        {
            Console.Beep();
            Energy--;
            if (Energy <= 0) Energy = 0;
            Lubricity--;
            if (Lubricity <= 0) Lubricity = 0;
            Happiness--;
            if (Happiness <= 0) Happiness = 0;
        }
        public void Charge()
        {
            Energy += IncreaseAmount;
            if (Energy >= Max) Energy = Max;
            Console.Clear();
            Console.WriteLine("\tYou just Charged " + Name + " !");
        }
        public void Lubricate()
        {
            Lubricity += IncreaseAmount;
            if (Lubricity >= Max) Lubricity = Max;
            Console.Clear();
            Console.WriteLine("\tYou just Lubricated " + Name + " !");
        }
            
        public override void DisplayPetInfo()
        {
            Console.Write("\n\tYour " + Species + ", " + Name + ", is " + Age + " years old.\n\n");

            Console.Write("\n\tLubricity:  ");
            PrintStatusBar(Lubricity, 2);
            Console.Write("\n\tHappiness:  ");
            PrintStatusBar(Happiness, 2);
            Console.Write("\n\tEnergy:     ");
            PrintStatusBar(Energy, 2);
            Console.WriteLine("\n");
        }
        public void DisplayPetStats()
        {
            //Console.Write("\tFullness:  ");
            PrintStatusBar(Lubricity, 2);
            //Console.Write("\tHappiness: ");
            PrintStatusBar(Happiness, 2);
            //Console.Write("\tEnergy:    ");
            PrintStatusBar(Energy, 2);
            //Console.WriteLine("\n");
        }

        public bool DisplayInteractionMenu()
        {

            bool interacted = true;

            Console.WriteLine("\n_____________________________________________\n");

            Console.WriteLine("\n\tChoose an action from the menu:\n");
            Console.WriteLine("\tP - Play");
            Console.WriteLine("\tC - Charge ");
            Console.WriteLine("\tL - Lubricate");
            Console.WriteLine("\tE - Go Back to Shelter");
            Console.Write("\n\tEntry.........: ");
            string entry = Console.ReadLine();

            switch (entry.ToLower())
            {
                case "c":
                   Charge();
                    break;
                case "l":
                    Lubricate();
                    break;
                case "p":
                    Play();
                    break;
                default:
                    interacted = false;
                    break;
            }
            return (interacted);
        }
        public string GetPetInfo()
        {
            return ( Species + " " + Name + " " + Age.ToString());
        }
        public string GetPetInfoFormatted()
        {
            string s = Species.PadRight(15);
            string n = Name.PadRight(15);
            string a = Age.ToString().PadRight(6);
            return (s + n + a);
        }
        /*public override bool IsAlive()//All need to be above 0
        {
            if (Happiness > 0 && Energy > 0 && Lubricity > 0)
            {
                return (true); //alive
            }
            else
            {
                return (false); //dead
            }
        }*/
        public override bool IsAlive()//One attribute need to be above 0
        {
            if (Happiness > 0 || Energy > 0 || Lubricity > 0)
            {
                return (true); //alive
            }
            else
            {
                return (false); //dead
            }
        }
    }
}