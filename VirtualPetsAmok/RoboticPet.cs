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
            Lubricity--;
        }
        public void Charge()
        {
            Energy += IncreaseAmount;
            Console.Clear();
            Console.WriteLine("\tYou just Charged " + Name + " !");
        }

    }
}
