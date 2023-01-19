using HeroAppLibrary.Models.ItemModels;
using HeroAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Tests
{
    public class CreateNewWeaponTests
    {
        [Fact]
        public void CreateWeapon_ShouldReturnCorrect_NameRequiredLevelSlotWeaponTypeDamage()
        {
            Array values = Enum.GetValues(typeof(WeaponTypes));
            Random random = new Random();
            WeaponTypes randomBar = (WeaponTypes)values.GetValue(random.Next(values.Length));
            SlotTypes randomSlot = (SlotTypes)values.GetValue(random.Next(values.Length));
            // Arrange
            var test = new WeaponModel("Test", 1, randomSlot, randomBar, 1);
            var expectedItemName = "Test";
            var expectedRequiredLevel = 1;
            var expectedSlotType = randomSlot;
            var expectedArmorType = randomBar;
            var expectedDamage = 1;

            // Act
            var actualItemName = test.ItemName;
            var actualRequiredLevel = test.RequiredLevel;
            var actualSlotType = test.SlotType;
            var actualArmorType = test.WeaponType;
            var actualDamage = test.Damage;

            // Assert
            Assert.Equal(expectedItemName, actualItemName);
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
            Assert.Equal(expectedSlotType, actualSlotType);
            Assert.Equal(expectedArmorType, actualArmorType);
            Assert.Equal(expectedDamage, actualDamage);
        }
    }
}
