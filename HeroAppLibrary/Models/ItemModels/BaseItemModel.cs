using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAppLibrary.Models.ItemModels
{
    public abstract class BaseItemModel
    {
        public string ItemName { get; set; }
        public int RequiredLevel { get; set; }
        public SlotTypes SlotType { get; set; }

        public BaseItemModel(string itemName, int requiredLevel, SlotTypes slotTypes)
        {
            ItemName = itemName;
            RequiredLevel = requiredLevel;
            SlotType = slotTypes;
        }
    }
}
