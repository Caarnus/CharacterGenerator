using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ResistanceModel
    {
        public int IdNum { get; set; }
        public DamageTypeModel DamageType { get; set; } = new DamageTypeModel();
        public string Condition { get; set; }
        public decimal ResistAmount { get; set; }
    }
}
