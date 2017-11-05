using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ClassModel
    {
        public string Name { get; set; }
        public string HitDice { get; set; }
        public int StartingHealth { get; set; }
        public int DefaultHPPerLevel { get; set; }
        public string DiceHPPerLevel { get; set; }
        public List<ArmorModel> ArmorList { get; set; } = new List<ArmorModel>();
        public List<WeaponModel> WeaponList { get; set; } = new List<WeaponModel>();
        public List<ToolModel> ToolList { get; set; } = new List<ToolModel>();
        public List<SavingThrowModel> SavingThrowList { get; set; } = new List<SavingThrowModel>();
        public List<SkillModel> SkillList { get; set; } = new List<SkillModel>();
        public List<EquipmentModel> StartingEquipmentList { get; set; } = new List<EquipmentModel>();
        public List<FeatureModel> BaseClassFeatureList { get; set; } = new List<FeatureModel>();
        public int AchetypeLevel { get; set; }
        public List<ArchetypeModel> ArchetypeList { get; set; } = new List<ArchetypeModel>();
        public List<ProficiencyBonusModel> ProficiencyBonusList { get; set; } = new List<ProficiencyBonusModel>();
        public List<SpellSlotsModel> SpellSlotList { get; set; } = new List<SpellSlotsModel>();
        public List<SpellModel> SpellList { get; set; } = new List<SpellModel>();
        public int NumberAvailableArmorProficiencies { get; set; }
        public int NumberAvailableWeaponProficiencies { get; set; }
        public int NumberAvailableToolProficiencies { get; set; }
        public int NumberAvailableSkillProficiencies { get; set; }
        public List<ArmorModel> AvailableArmorList { get; set; } = new List<ArmorModel>();
        public List<WeaponModel> AvailableWeaponList { get; set; } = new List<WeaponModel>();
        public List<ToolModel> AvailableToolList { get; set; } = new List<ToolModel>();
        public List<SkillModel> AvailableSkillList { get; set; } = new List<SkillModel>();
        public AbilityScoreImprovementModel AbilityScoreImpovement { get; set; } = new AbilityScoreImprovementModel();
    }
}
