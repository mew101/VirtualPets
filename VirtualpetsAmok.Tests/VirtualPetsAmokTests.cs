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

        



        
    }
}
