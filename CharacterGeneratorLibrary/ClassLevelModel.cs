using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ClassLevelModel
    {
        public int idNum { get; set; }
        public ClassModel ClassType { get; set; } = new ClassModel();
        public int Level { get; set; }
    }
}
