using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.CharacterModels
{
    public class WarriorModel : BaseCharacterModel
    {
        public WarriorModel(string characterName, int level, int strength, int dexterity, int intelligence) : base(characterName, level, strength, dexterity, intelligence)
        {
            CharacterName = "Warrior";
            Level = 1;
            Strength = 5;
            Dexterity = 2;
            Intelligence = 1;
        }
    }
}
