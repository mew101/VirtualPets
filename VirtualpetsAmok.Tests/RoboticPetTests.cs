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

        public void Create_RoboticPet()
        {
            RoboticPet robotic = new RoboticPet();
        }
        [Fact]
        public void Name_RoboticPet()
        {
            RoboticPet pet = new RoboticPet
            {
                Name = "Alexa"
            };

            Assert.Equal("Alexa", pet.Name);
        }
    }
}