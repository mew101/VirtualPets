using System.Collections.Generic;

namespace VirtualPetsAmok
{
    public class Shelter
    {
        public List<VirtualPet> Pets { set; get; }

        public Shelter()
        {
            Pets = new List<VirtualPet>();

            Pets.Add(new VirtualPet("Dog", "Buster", 3));
            Pets.Add(new VirtualPet("Cat", "Billy", 7));
            Pets.Add(new VirtualPet("Cat", "Dexter", 2));
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
