using HeroAppLibrary.Models.ItemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.CharacterModels
{
    public class MageModel : BaseCharacterModel
    {
        public List<WeaponModel> Weapon { get; set; }
        public MageModel(string characterName, int level, int strength, int dexterity, int intelligence) : base(characterName, level, strength, dexterity, intelligence)
        {
            // Set default values
            CharacterName = "Mage";
            Level = 1;
            Strength = 1;
            Dexterity = 1;
            Intelligence = 8;
        }        
    }
}
