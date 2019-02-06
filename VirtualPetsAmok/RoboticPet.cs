using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class RoboticPet : VirtualPet
    {
        int Lubricity { get; set; }

        public RoboticPet(string s, string n, int a)
        {
            Species = s;
            Name = n;
            Age = a;
            Energy = 5;  //battery level
            Lubricity = 5;           
        }
       



    }
}
