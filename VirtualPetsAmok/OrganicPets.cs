using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class OrganicPet : VirtualPet
    {
        public int Fullness { get; set; }
        public int Happiness { get; set; }

        public OrganicPet(string s, string n, int a) : base(s, n, a)
        {
            //Species = s;
            //Name = n;
            //Age = a;
            //Energy = 5;
            Happiness = 5;
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

        public void Play()
        {
            Happiness += IncreaseAmount;
            Console.Clear();
            Console.WriteLine("\tYou just PLAYED with " + Name + " !");
        }
    }    
}
