using HeroAppLibrary.Models;
using HeroAppLibrary.Models.ItemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Tests
{
    public class CreateNewArmorTests
    {
        [Fact]
        public void CreateArmor_ShouldReturnCorrect_NameRequiredLevelSlotArmorTypeArmorAttribute()
        {
            Array values = Enum.GetValues(typeof(ArmorTypes));
            Random random = new Random();
            ArmorTypes randomBar = (ArmorTypes)values.GetValue(random.Next(values.Length));
            SlotTypes randomSlot = (SlotTypes)values.GetValue(random.Next(values.Length));
            // Arrange
            var test = new ArmorModel("Test", 1, randomSlot, randomBar, 1, 1, 1 );
            var expectedItemName = "Test";
            var expectedRequiredLevel = 1;
            var expectedSlotType = randomSlot;
            var expectedArmorType = randomBar;
            var expectedStrength = 1;
            var expectedDexterity = 1;
            var expectedIntelligence = 1;


            // Act
            var actualItemName = test.ItemName;
            var actualRequiredLevel = test.RequiredLevel;
            var actualSlotType = test.SlotType;
            var actualArmorType = test.ArmorType;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;

            // Assert
            Assert.Equal(expectedItemName, actualItemName);
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
            Assert.Equal(expectedSlotType, actualSlotType);
            Assert.Equal(expectedArmorType, actualArmorType);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
    }
}
