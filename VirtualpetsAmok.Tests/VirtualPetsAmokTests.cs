using System;
using VirtualPetsAmok;
using Xunit;

namespace VirtualpetsAmok.Tests
{
    public class PetTests
    {
        [Fact]
        public void Create_Pet()
        {
            //Create Pet
            VirtualPet pet = new VirtualPet();
        }
        [Fact]
        public void Pet_Name()
        {
            //Create Pet Name
            VirtualPet pet = new VirtualPet();

            pet.Name = "Sparky";

            Assert.Equal("Sparky", pet.Name);
        }
        [Fact]
        public void Pet_Age()
        {
            //Create Pet Age
            VirtualPet pet = new VirtualPet();
                        
            pet.Age = 7;

            Assert.Equal(7, pet.Age);
        }
        [Fact]
        public void Pet_Hunger()
        {
            //Create Pet Hunger Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();
            
            pet.Hunger = 4;

            Assert.Equal(4, pet.Hunger);
        }






    }
}
