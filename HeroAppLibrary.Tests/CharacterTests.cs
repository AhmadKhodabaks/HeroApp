using HeroAppLibrary.Models.ItemModels;
using HeroAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroAppLibrary.Models.CharacterModels;

namespace HeroAppLibrary.Tests
{
    public class CharacterTests
    {
        #region Creates different characters
        [Fact]
        public void CreateMageCharacter_ShouldReturnCorrect_NameLevelAttributes()
        {
            
            // Arrange
            var test = new MageModel("", 1, 1, 1, 8);
            
            var expectedCharacterName = "Mage";
            var expectedLevel = 1;
            var expectedStrength = 1;
            var expectedDexterity = 1;
            var expectedIntelligence = 8;
                      
            // Act
            var actualCharacterName = test.CharacterName;
            var actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;
           

            // Assert
            Assert.Equal(expectedCharacterName, actualCharacterName);
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);

        }
        [Fact]
        public void CreateRangerCharacter_ShouldReturnCorrect_NameLevelAttributes()
        {
            // Arrange
            var test = new RangerModel("", 1, 1, 7, 1);
            var expectedCharacterName = "Ranger";
            var expectedLevel = 1;
            var expectedStrength = 1;
            var expectedDexterity = 7;
            var expectedIntelligence = 1;

            // Act
            var actualCharacterName = test.CharacterName;
            var actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;

            // Assert
            Assert.Equal(expectedCharacterName, actualCharacterName);
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);

        }
        [Fact]
        public void CreateRogueCharacter_ShouldReturnCorrect_NameLevelAttributes()
        {
            // Arrange
            var test = new RogueModel("", 1, 1, 7, 1);
            var expectedCharacterName = "Rogue";
            var expectedLevel = 1;
            var expectedStrength = 2;
            var expectedDexterity = 6;
            var expectedIntelligence = 1;

            // Act
            var actualCharacterName = test.CharacterName;
            var actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;

            // Assert
            Assert.Equal(expectedCharacterName, actualCharacterName);
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);

        }
        [Fact]
        public void CreateWarriorCharacter_ShouldReturnCorrect_NameLevelAttributes()
        {
            // Arrange
            var test = new WarriorModel("", 1, 5, 2, 1);
            var expectedCharacterName = "Warrior";
            var expectedLevel = 1;
            var expectedStrength = 5;
            var expectedDexterity = 2;
            var expectedIntelligence = 1;

            // Act
            var actualCharacterName = test.CharacterName;
            var actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;

            // Assert
            Assert.Equal(expectedCharacterName, actualCharacterName);
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);            
        }
        #endregion

        #region Increasement in the level of Attributes
        [Fact]
        public void IncreaseMageAttributes_ShouldReturnCorrect_AmountAttributes()
        {
            // Arrange
            var test = new MageModel("", 1, 1, 1, 8);
            test.LevelUp(1, 1, 1, 5);

            var expectedLevel = 2;
            var expectedStrength = 2;
            var expectedDexterity = 2;
            var expectedIntelligence = 13;

            // Act
            int actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;


            // Assert
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void IncreaseRangerAttributes_ShouldReturnCorrect_AmountAttributes()
        {
            // Arrange
            var test = new RangerModel("", 1, 1, 1, 8);
            test.LevelUp(1, 1, 5, 1);

            var expectedLevel = 2;
            var expectedStrength = 2;
            var expectedDexterity = 12;
            var expectedIntelligence = 2;

            // Act
            int actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;


            // Assert
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void IncreaseRogueAttributes_ShouldReturnCorrect_AmountAttributes()
        {
            // Arrange
            var test = new RogueModel("", 1, 1, 1, 8);
            test.LevelUp(1, 1, 4, 1);

            var expectedLevel = 2;
            var expectedStrength = 3;
            var expectedDexterity = 10;
            var expectedIntelligence = 2;

            // Act
            int actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;


            // Assert
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        [Fact]
        public void IncreaseWarriorAttributes_ShouldReturnCorrect_AmountAttributes()
        {
            // Arrange
            var test = new WarriorModel("", 1, 1, 1, 8);
            test.LevelUp(1, 3, 2, 1);

            var expectedLevel = 2;
            var expectedStrength = 8;
            var expectedDexterity = 4;
            var expectedIntelligence = 2;

            // Act
            int actualLevel = test.Level;
            var actualStrength = test.Strength;
            var actualDexterity = test.Dexterity;
            var actualIntelligence = test.Intelligence;


            // Assert
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        #endregion
    }
}
