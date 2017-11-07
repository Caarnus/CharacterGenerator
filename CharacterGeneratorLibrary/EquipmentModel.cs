using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class EquipmentModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public decimal WeightPerUnit { get; set; }
        public decimal UnitQuantity { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public int BonusAmount { get; set; }
        public string ItemType { get; set; }
        public string ItemSubtype { get; set; }
    }
}