using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ClassLevelModel
    {
        public List<ClassModel> ClassType { get; set; } = new List<ClassModel>();
        public List<int> LevelList { get; set; } = new List<int>();
    }
}
