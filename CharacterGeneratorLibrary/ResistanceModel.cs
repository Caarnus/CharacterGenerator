using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class ResistanceModel
    {
        public int ResistId { get; set; }
        public string DamageType { get; set; }
        public string Condition { get; set; }
        public decimal ResistAmount { get; set; }
    }
}
