using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.CharacterModels
{
    public class RogueModel : BaseCharacterModel
    {
        public RogueModel(string characterName, int level, int strength, int dexterity, int intelligence) : base(characterName, level, strength, dexterity, intelligence)
        {
            CharacterName = "Rogue";
            Level = 1;
            Strength = 2;
            Dexterity = 6;
            Intelligence = 1;
        }
    }
}
