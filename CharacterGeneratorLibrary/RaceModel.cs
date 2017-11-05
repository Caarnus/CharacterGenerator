using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class RaceModel
    {
        public string Name { get; set; }
        public int StrPlus { get; set; }
        public int DexPlus { get; set; }
        public int ConPLus { get; set; }
        public int IntPlus { get; set; }
        public int WisPlus { get; set; }
        public int ChaPlus { get; set; }
        public int LifeExpectancy { get; set; }
        public char Size { get; set; }
        public int Speed { get; set; }
        public string VisionType { get; set; }
        public string DescPhysical { get; set; }
        public string DescAlign { get; set; }
        public string DescAttitude { get; set; }
        public List<LanguageModel> Language { get; set; } = new List<LanguageModel>();
        public List<SkillModel> SkillProficiencyList { get; set; } = new List<SkillModel>();
        public List<WeaponModel> WeaponProficiencyList { get; set; } = new List<WeaponModel>();
        public List<ArmorModel> ArmorProficiencyList { get; set; } = new List<ArmorModel>();
        public List<ToolModel> ToolProficiencyList { get; set; } = new List<ToolModel>();
        public List<ResistanceModel> ResistanceList { get; set; } = new List<ResistanceModel>();
        public List<SpellModel> SpellList { get; set; } = new List<SpellModel>();
        public List<FeatModel> FeatList { get; set; } = new List<FeatModel>();
        public int BonusAttribute { get; set; }
        public int BonusFeat { get; set; }
        public int BonusSkill { get; set; }
        public int BonusLanguage { get; set; }
        public int BonusSpell { get; set; }
        public int BonusWeapon { get; set; }
        public int BonusArmor { get; set; }
        public List<AttributeModel> BonusAttributeList { get; set; } = new List<AttributeModel>();
        public List<FeatModel> BonusFeatList { get; set; } = new List<FeatModel>();
        public List<SkillModel> BonusSkillList { get; set; } = new List<SkillModel>();
        public List<LanguageModel> BonusLanguageList { get; set; } = new List<LanguageModel>();
        public List<SpellModel> BonusSpellList { get; set; } = new List<SpellModel>();
        public List<WeaponModel> BonusWeaponList { get; set; } = new List<WeaponModel>();
        public List<ArmorModel> BonusArmorList { get; set; } = new List<ArmorModel>();
    }
}
