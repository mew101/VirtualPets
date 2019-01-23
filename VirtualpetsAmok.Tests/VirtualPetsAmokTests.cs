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
            VirtualPet pet = new VirtualPet
            {
                Name = "Sparky"
            };

            Assert.Equal("Sparky", pet.Name);
        }
        [Fact]
        public void Pet_Age()
        {
            //Create Pet Age
            VirtualPet pet = new VirtualPet
            {
                Age = 7
            };

            Assert.Equal(7, pet.Age);
        }
        [Fact]
        public void Pet_Hunger()
        {
            //Create Pet Hunger Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();
            
            //pet.Hunger = 4;

            Assert.Equal(5, pet.Hunger);
        }
        [Fact]
        public void Pet_Species()
        {
            //Create Pet Species
            VirtualPet pet = new VirtualPet
            {
                Species = "kitty",
                Name = "Sam"
            };

            Assert.Equal("kitty", pet.Species);
            Assert.Equal("Sam", pet.Name);
        }
        [Fact]
        public void Pet_Boredom()
        {
            //Create Pet Boredom Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();

            //default boredom is 5

            Assert.Equal(5, pet.Boredom);
        }
        [Fact]
        public void Pet_Fatigue()
        {
            //Create Pet Fatigue Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();

            //default fatigue is 5

            Assert.Equal(5, pet.Fatigue);
        }
        [Fact]
        public void Pet_TimeIncrement()
        {
            VirtualPet pet = new VirtualPet();

            pet.TimeIncrement();

            Assert.Equal(4, pet.Fatigue);
            Assert.Equal(4, pet.Boredom);
            Assert.Equal(4, pet.Hunger);
        }



    }
}
