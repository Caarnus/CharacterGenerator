using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class SpellModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int CastTime { get; set; }
        public int Duration { get; set; }
        public int Range { get; set; }
        public bool Verbal { get; set; }
        public bool Somatic { get; set; }
        public bool Material { get; set; }
        public string MaterialDesc { get; set; }
        public bool MaterialConsumed { get; set; }
        public bool Concentration { get; set; }
        public bool Ritual { get; set; }
        public bool Attack { get; set; }
        public bool Reaction { get; set; }
        public string Description { get; set; }
        public int LevelReq { get; set; }
        public bool Prepared { get; set; }
    }
}
