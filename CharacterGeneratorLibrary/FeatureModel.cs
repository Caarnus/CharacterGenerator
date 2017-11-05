using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class FeatureModel
    {
        public string Name { get; set; }
        public string TiedTo { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public List<LanguageModel> LanguageList { get; set; } = new List<LanguageModel>();
        public List<WeaponModel> WeaponList { get; set; } = new List<WeaponModel>();
        public List<ArmorModel> ArmorList { get; set; } = new List<ArmorModel>();
        public List<SpellModel> SpellList { get; set; } = new List<SpellModel>();
        public List<SkillModel> SkillList { get; set; } = new List<SkillModel>();
        public List<FeatModel> FeatList { get; set; } = new List<FeatModel>();
        public List<ResistanceModel> ResistanceList { get; set; } = new List<ResistanceModel>();
    }
}
