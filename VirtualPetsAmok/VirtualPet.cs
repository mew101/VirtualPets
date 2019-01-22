using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
   public class VirtualPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Hunger { get; set; }
        public string Species { get; set; }

        public int Fatigue { get; set; }
        public int Boredom { get; set; }

        public VirtualPet()
        {
            Name = "default";
            Fatigue = 5;
            Boredom = 5;
            Hunger = 5;
            
        }
        public void TimeIncrement()
        {
            Fatigue--;
            Boredom--;
            Hunger--;
        }
    }
}
