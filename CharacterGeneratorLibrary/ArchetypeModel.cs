using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ArchetypeModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public List<FeatureModel> FeatureList { get; set; } = new List<FeatureModel>();
    }
}