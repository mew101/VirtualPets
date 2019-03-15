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
        public int HowManyPetsInShelter()
        {
            return (NumPets);
        }
        public void CreateOrgPet()
        {
            Console.WriteLine("Create Organic Pet");
            OrganicPet temp = new OrganicPet(" ", " ", 1);
            temp.SpecifyPet();
            AddOrgPet(temp);
        }
        public void CreateRoboPet()
        {
            Console.WriteLine("Create Robotic Pet");
            RoboticPet temp = new RoboticPet(" ", " ", 1);
            temp.SpecifyPet();
            AddRoboPet(temp);
            Console.WriteLine();
        }
        public void AddRoboPet(RoboticPet aPet)
        {
            RoboPets.Add(aPet);
            NumPets++;
        }
 
        public void RemoveRoboPet(int n)
        {
            RoboPets.RemoveAt(n);
            NumPets--;
        }

        public void AddOrgPet(OrganicPet aPet)
        {
            OrgPets.Add(aPet);
            NumPets++;
        }

        public void RemoveOrgPet(int n)
        {
            OrgPets.RemoveAt(n);
            NumPets--;
        }
        public void RemoveOrgPet(OrganicPet temp)
        {
            OrgPets.Remove(temp);
            NumPets--;
        }
        public void RemoveRoboPet(RoboticPet temp)
        {
            RoboPets.Remove(temp);
            NumPets--;
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
        public void RemoveAPet(int index)
        {
            index--;
            if (index >= OrgPets.Count)
            {
                RemoveRoboPet(index - OrgPets.Count);
            }
            else
            {
                RemoveOrgPet(index);
            }
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
            index--; //reduce by 1 since index starts @ 0
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
        public void DisplayAllPetsZ()
        {
            Console.WriteLine("\t\t\t===== Shelter =====\n");
            Console.WriteLine("\n\t   Species        Name           Age   Type");
            for (int i = 0; i < OrgPets.Count; i++)
            {
                int d = i + 1;
                Console.WriteLine("\t" + d + ". " + OrgPets[i].GetPetInfoFormatted()+"Organic");
            }
            for (int p = 0; p < RoboPets.Count; p++)
            {
                //change to method 
                int x = (OrgPets.Count) + p + 1;

                Console.WriteLine("\t" + x + ". " + RoboPets[p].GetPetInfoFormatted() + "Robotic");
            }
        }
        public void DisplayAllPetsZZ()
        {
            Console.WriteLine("\t\t\t===== Shelter =====\n");
            Console.WriteLine("\n\t   Species        Name           Age   Type      \n");
            for (int i = 0; i < OrgPets.Count; i++)
            {
                int d = i + 1;
                Console.Write("\t" + d + ". " + OrgPets[i].GetPetInfoFormatted() + "Organic   ");
                OrgPets[i].DisplayPetStats();
            }
            for (int p = 0; p < RoboPets.Count; p++)
            {
                int x = (OrgPets.Count) + p + 1;
                Console.Write("\t" + x + ". " + RoboPets[p].GetPetInfoFormatted() + "Robotic   ");
                RoboPets[p].DisplayPetStats();
            }
        }
        public void TimePasses()
        {
            foreach (OrganicPet xxx in OrgPets)
            {
                xxx.TimeIncrement();
            }
            foreach (RoboticPet yyy in RoboPets)
            {
                yyy.TimeIncrement();
            }
        }
        public void CheckForDeath()
        {
            int[] removals = new int[20];
            int howMany = 0;
            for (int i = 0; i < OrgPets.Count; i++)
            {
                if (!OrgPets[i].IsAlive())
                {
                    OrgPets[i].PetDies();
                    removals[howMany] = i;
                    howMany++;

                }
            }
            for (int x=howMany-1; x>=0; x--)
            {
                RemoveOrgPet(removals[x]);
            }

            
            howMany = 0;
            for (int i = 0; i < RoboPets.Count; i++)
            {
                if (!RoboPets[i].IsAlive())
                {
                    RoboPets[i].PetDies();
                    removals[howMany] = i;
                    howMany++;

                }
            }
            for (int x = howMany - 1; x >= 0; x--)
            {
                RemoveRoboPet(removals[x]);
            }

        }
    }
    
}
