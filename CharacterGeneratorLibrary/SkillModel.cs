using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class SkillModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public AttributeModel GovenringAttrib { get; set; } = new AttributeModel();
        public bool Advantage { get; set; }
        public string Special { get; set; }
        public bool Proficient { get; set; }
    }
}
