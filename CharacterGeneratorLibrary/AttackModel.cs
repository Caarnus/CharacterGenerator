using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class AttackModel
    {
        public int AttackId { get; set; }
        public string AttackName { get; set; }
        public string AttackSource { get; set; }
        public DiceModel DiceRoll { get; set; } = new DiceModel();
        public DamageModel DamageType { get; set; }
    }
}
