using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetsAmok;
using Xunit;

namespace VirtualpetsAmok.Tests
{
    public class RoboticPetTests
    {
        [Fact]
        public void Name_RoboticPet()
        {
            RoboticPet pet = new RoboticPet("Dog", "Alexa", 2);


            Assert.Equal("Alexa", pet.Name);
            Assert.Equal("Dog", pet.Species);
            Assert.Equal(2, pet.Age);
        }
        [Fact]
        public void RoboticPet_Time_Increment()
        {
            RoboticPet pet = new RoboticPet("Dog", "Alexa", 2);

            pet.TimeIncrement();

            Assert.Equal(4, pet.Energy);
            Assert.Equal(4, pet.Lubricity);
        }
        [Fact]
        public void RoboticPet_Charge()
        {
            RoboticPet pet = new RoboticPet("Dog", "Alexa", 2);

            pet.Charge();

            Assert.Equal(10, pet.Energy);
        }
    }
}