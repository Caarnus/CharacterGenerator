using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class VisionModel
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public int DarkAsDim { get; set; }
        public int DimAsBright { get; set; }
        public int Blind { get; set; }
        public bool IllusionAffected { get; set; }
        public bool SeeMagicDark { get; set; }
    }
}
