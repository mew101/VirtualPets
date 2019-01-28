using System.Collections.Generic;

namespace VirtualPetsAmok
{
    public class Shelter
    {
        public List<VirtualPet> Pets { set; get; }

        public Shelter()
        {
            Pets = new List<VirtualPet>();  
        }
        public void AddPet(VirtualPet aPet)
        {
            Pets.Add(aPet);
        }
        public void RemovePet(int n)
        {
            Pets.RemoveAt(n);
        }
    
    }
}
