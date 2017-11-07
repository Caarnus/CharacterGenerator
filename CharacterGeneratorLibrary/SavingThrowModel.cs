using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class SavingThrowModel
    {
        public string Name { get; set; }
        public AttributeModel Attribute { get; set; } = new AttributeModel();
        public bool Advantage { get; set; }
        public string Special { get; set; }
        public bool Proficient { get; set; }
    }
}
