using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.ItemModels
{
    public class WeaponModel : BaseItemModel
    {
        public WeaponTypes WeaponType { get; set; }
        public int Damage { get; set; }

        public WeaponModel(string itemName, int requiredLevel, SlotTypes slotTypes, WeaponTypes weaponTypes, int damage) : base(itemName, requiredLevel, slotTypes)
        {
            WeaponType = weaponTypes;
            Damage = damage;
        }
    }
}
