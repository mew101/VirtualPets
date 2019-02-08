using System.Collections.Generic;
using System.Text;
using System;

namespace VirtualPetsAmok
{
    public class Shelter
    {
        public List<OrganicPet> OrgPets { set; get; }
        public List<RoboticPet> RoboPets { set; get; }
        public int NumPets { set; get; }
        public Shelter()
        {
            OrgPets = new List<OrganicPet>();

            OrgPets.Add(new OrganicPet("Dog", "Buster", 3));
            OrgPets.Add(new OrganicPet("Cat", "Billy", 7));

            RoboPets = new List<RoboticPet>();

            RoboPets.Add(new RoboticPet("Dog", "Dex", 6));
            RoboPets.Add(new RoboticPet("Cat", "Molly", 8));

            NumPets = OrgPets.Count + RoboPets.Count;
        }
        
        public void AddRoboPet(RoboticPet aPet)
        {
            RoboPets.Add(aPet);
        }
 
        public void RemoveRoboPet(int n)
        {
            RoboPets.RemoveAt(n);
        }

        public void AddOrgPet(OrganicPet aPet)
        {
            OrgPets.Add(aPet);
        }

        public void RemoveOrgPet(int n)
        {
            OrgPets.RemoveAt(n);
        }
        public int GetNumPets()
        {
            return NumPets;
        }
        public int GetNumOrganicPets()
        {
            return OrgPets.Count;
        }
        public int GetNumRoboticPets()
        {
            return RoboPets.Count;
        }
        public void DisplayShelterPetInfo(int index)
        {
            index--;
            if (index >= OrgPets.Count)
            {
                RoboPets[index - OrgPets.Count].DisplayPetInfo();
            }
            else
            {
                OrgPets[index].DisplayPetInfo();
            }
        }
        public bool DisplayShelterPetInteractions(int index)
        {
            index--;
            bool continueInteracting;
            if (index >= OrgPets.Count)
            {
                continueInteracting = RoboPets[index - OrgPets.Count].DisplayInteractionMenu();
            }
            else
            {
                continueInteracting = OrgPets[index].DisplayInteractionMenu();
            }
            return (continueInteracting);
        }

        public void DisplayAllPets()
        {
            Console.WriteLine("\n\tOrganic Pets");
            for (int i = 0; i < OrgPets.Count; i++)
            {
                int d = i + 1;
                Console.WriteLine("        " + d + ". " + OrgPets[i].GetPetInfo());
            }
            Console.WriteLine("\n\tRobotic Pets");
            for (int p = 0; p < RoboPets.Count; p++)
            {
                //change to method 
                int x = (OrgPets.Count) + p + 1;

                Console.WriteLine("        " + x +". " + RoboPets[p].GetPetInfo());
            }
        }
    }
    
}
