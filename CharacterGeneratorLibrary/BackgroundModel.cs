using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class BackgroundModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public List<SkillModel> SkillProficiencyList { get; set; } = new List<SkillModel>();
        public int ToolProficiencyNumber { get; set; }
        public List<ToolModel> ToolProficiencyList { get; set; } = new List<ToolModel>();
        public int LanguageNumber { get; set; }
        public List<ItemModel> ItemsList { get; set; } = new List<ItemModel>();
        public List<FeatureModel> FeatureList { get; set; } = new List<FeatureModel>();
        public string Description { get; set; }
    }
}
