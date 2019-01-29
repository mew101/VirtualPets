using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetsAmok;
using Xunit;

namespace VirtualpetsAmok.Tests
{
    public class ShelterTests
    {
        [Fact]

        public void Shelter_Is_Empty()
        {
            Shelter xxx = new Shelter();
            Assert.Empty(xxx.Pets);

        }
        [Fact]
        public void Pet_Is_Added()
        {
            var xxx = new Shelter();
            var billy = new VirtualPet();
            xxx.AddPet(billy);
            Assert.NotEmpty(xxx.Pets);
        }
        [Fact]
        public void Pet_Is_Removed()
        {
            var xxx = new Shelter();
            var bob = new VirtualPet();
            xxx.AddPet(bob);
            xxx.RemovePet(0);
            Assert.Empty(xxx.Pets);
        }

    }
}
