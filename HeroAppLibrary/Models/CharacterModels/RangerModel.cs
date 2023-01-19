using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.CharacterModels
{
    public class RangerModel : BaseCharacterModel
    {
        public RangerModel(string characterName, int level, int strength, int dexterity, int intelligence) : base(characterName, level, strength, dexterity, intelligence)
        {
            CharacterName = "Ranger";
            Level = 1;
            Strength = 1;
            Dexterity = 7;
            Intelligence = 1;
        }
    }
}
