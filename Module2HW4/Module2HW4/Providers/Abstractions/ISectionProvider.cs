using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;

namespace Module2HW4.Providers.Abstractions
{
    public interface ISectionProvider
    {
        public Animal[] AnimalsInSection { get; set; }
    }
}
