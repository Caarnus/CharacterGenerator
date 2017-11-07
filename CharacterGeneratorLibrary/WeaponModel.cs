using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class WeaponModel
    {
        public string Type { get; set; }
        public string WeaponClass { get; set; }
        public bool Ranged { get; set; }
        public bool Ammunition { get; set; }
        public bool Finesse { get; set; }
        public bool Heavy { get; set; }
        public bool Light { get; set; }
        public bool Loading { get; set; }
        public int RangeFirst { get; set; }
        public int RangeSecond { get; set; }
        public bool Reach { get; set; }
        public bool Special { get; set; }
        public bool Thrown { get; set; }
        public bool TwoHanded { get; set; }
        public bool Versatile { get; set; }
        public DamageModel Damage { get; set; } = new DamageModel();
        public DamageModel VersatileDamage { get; set; } = new DamageModel();
        public string Price { get; set; }
        public decimal Weight { get; set; }
        public bool Silvered { get; set; }
        public bool Proficient { get; set; }
    }
}
