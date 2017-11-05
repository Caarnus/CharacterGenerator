using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ArmorModel
    {
        public string Type { get; set; }
        public string Class { get; set; }
        public int Cost { get; set; }
        public int ArmorClass { get; set; }
        public bool AddDex { get; set; }
        public int StrengthRequirement { get; set; }
        public bool StealthImpaired { get; set; }
        public decimal Weight { get; set; }
        public int DonTime { get; set; }
        public int DoffTime { get; set; }
    }
}
