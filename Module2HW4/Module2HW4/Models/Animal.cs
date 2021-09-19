using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Enums;

namespace Module2HW4.Models
{
    public abstract class Animal
    {
        public string Name { get; init; }
        public bool IsListedInTheRedBook { get; init; }
        public Regions Region { get; init; }
    }
}
