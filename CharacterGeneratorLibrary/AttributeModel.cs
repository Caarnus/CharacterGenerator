using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class AttributeModel
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public bool Advantage { get; set; }
        public string Special { get; set; }
    }
}
