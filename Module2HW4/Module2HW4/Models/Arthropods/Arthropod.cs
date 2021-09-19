using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Enums;

namespace Module2HW4.Models.Arthropods
{
    public class Arthropod : Animal
    {
        public ArthropodClass ArthropodClass { get; init; }
        public bool IsPoisonous { get; init; }
    }
}
