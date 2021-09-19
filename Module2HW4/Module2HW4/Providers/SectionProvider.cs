using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4.Providers
{
    public class SectionProvider : ISectionProvider
    {
        public Animal[] AnimalsInSection { get; set; }
    }
}
