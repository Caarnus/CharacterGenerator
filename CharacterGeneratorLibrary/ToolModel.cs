using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ToolModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Cost { get; set; }
        public decimal Weight { get; set; }
        public bool Advantage { get; set; }
        public string Special { get; set; }
        public bool Proficient { get; set; }
    }
}
