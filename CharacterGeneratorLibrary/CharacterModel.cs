using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class CharacterModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public AlignmentModel Alignment { get; set; } = new AlignmentModel();
        public List<ClassLevelModel> ClassLevelList { get; set; } = new List<ClassLevelModel>();
        public RaceModel Race { get; set; } = new RaceModel();
        public BackgroundModel Background { get; set; } = new BackgroundModel();
        public string PlayerName { get; set; }
        public int Experience { get; set; }
        public int BaseStr { get; set; }
        public int BaseDex { get; set; }
        public int BaseCon { get; set; }
        public int BaseInt { get; set; }
        public int BaseWis { get; set; }
        public int BaseCha { get; set; }
        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<SavingThrowModel> SavingThrowList { get; set; } = new List<SavingThrowModel>();
        public List<SkillModel> SkillList { get; set; }
        public int PassivePerception { get; set; }
        public List<WeaponModel> WeaponList { get; set; }
        public List<ArmorModel> ArmorList { get; set; }
        public List<ToolModel> ToolList { get; set; }
        public List<LanguageModel> LanguageList { get; set; }
        public int ArmorClass { get; set; }
        public int InitiativeBonus { get; set; }
        public int Speed { get; set; }
        public int CurrentHP { get; set; }
        public int TempHP { get; set; }
        public int MaxHP { get; set; }
        public int MaxHitDice { get; set; }
        public int CurrentHitDice { get; set; }
        public int DeathSaveSuccess { get; set; }
        public int DeathSaveFail { get; set; }
        public List<AttackModel> AttackList { get; set; } = new List<AttackModel>();
        public int CopperAmount { get; set; }
        public int SilverAmount { get; set; }
        public int ElectrumAmount { get; set; }
        public int GoldAmount { get; set; }
        public int PlatinumAmount { get; set; }
        public List<EquipmentModel> EquipmentList { get; set; } = new List<EquipmentModel>();
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public List<FeatureModel> FeatureList { get; set; } = new List<FeatureModel>();
        public string AppearanceImageFilePath { get; set; }
        public string CharacterBackstory { get; set; }
        public string AlliesAndOrgFilePath { get; set; }
        public string AlliesAndOrganizations { get; set; }
        public List<FeatureModel> AdditionalFeatures { get; set; } = new List<FeatureModel>();
        public List<ItemModel> ItemList { get; set; } = new List<ItemModel>();
        public ClassModel SpellCastingClass { get; set; } = new ClassModel();
        public AttributeModel SpellCastingAbility { get; set; } = new AttributeModel();
        public int SpellSaveDC { get; set; }
        public int SpellAttackBonus { get; set; }
        public int SpellSlotMax1 { get; set; }
        public int SpellSlotRemaining1 { get; set; }
        public int SpellSlotMax2 { get; set; }
        public int SpellSlotRemaining2 { get; set; }
        public int SpellSlotMax3 { get; set; }
        public int SpellSlotRemaining3 { get; set; }
        public int SpellSlotMax4 { get; set; }
        public int SpellSlotRemaining4 { get; set; }
        public int SpellSlotMax5 { get; set; }
        public int SpellSlotRemaining5 { get; set; }
        public int SpellSlotMax6 { get; set; }
        public int SpellSlotRemaining6 { get; set; }
        public int SpellSlotMax7 { get; set; }
        public int SpellSlotRemaining7 { get; set; }
        public int SpellSlotMax8 { get; set; }
        public int SpellSlotRemaining8 { get; set; }
        public int SpellSlotMax9 { get; set; }
        public int SpellSlotRemaining9 { get; set; }
        public List<SpellModel> SpellList { get; set; }
    }
}
