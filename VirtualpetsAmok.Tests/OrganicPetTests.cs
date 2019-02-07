using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetsAmok;
using Xunit;

namespace VirtualpetsAmok.Tests
{
    public class OrganicPetTests
    {
        [Fact]
        public void Name_OrganicPet()
        {
            OrganicPet pet = new OrganicPet("Dog", "Alexa", 2);


            Assert.Equal("Alexa", pet.Name);
            Assert.Equal("Dog", pet.Species);
            Assert.Equal(2, pet.Age);
        }
        [Fact]
        public void OrganicPet_Time_Increment()
        {
            OrganicPet pet = new OrganicPet("Dog", "Alexa", 2);

            pet.TimeIncrement();

            Assert.Equal(4, pet.Energy);
            //Assert.Equal(4, pet);
        }
        [Fact]
        public void OrganicPet_Charge()
        {
            OrganicPet pet = new OrganicPet("Dog", "Alexa", 2);

           // pet.Charge();

            Assert.Equal(5, pet.Energy);
        }
        [Fact]
        public void Pet_Feed_A_Pet()
        {
            OrganicPet pet = new OrganicPet("Dog", "Alexa", 2);
           
            pet.Feed();

            Assert.Equal(10, pet.Fullness);
        }
    }
}