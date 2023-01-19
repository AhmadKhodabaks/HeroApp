using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.CharacterModels
{
    public abstract class BaseCharacterModel
    {
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public BaseCharacterModel(string characterName, int level, int strength, int dexterity, int intelligence)
        {
            CharacterName = characterName;
            Level = level;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
        public void LevelUp(int level, int strength, int dexterity, int intelligence)
        {
            this.Level += level;
            this.Strength += strength;
            this.Dexterity += dexterity;
            this.Intelligence += intelligence;
        }
       


    }
}
