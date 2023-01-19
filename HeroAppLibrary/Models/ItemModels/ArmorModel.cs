using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.ItemModels
{
    public class ArmorModel : BaseItemModel
    {
        public ArmorTypes ArmorType { get; set; }
        
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        
        public ArmorModel(string itemName, int requiredLevel, SlotTypes slotTypes, ArmorTypes armorTypes, int strength, int dexterity, int intelligence) : base(itemName, requiredLevel, slotTypes)
        {
            ArmorType = armorTypes;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
