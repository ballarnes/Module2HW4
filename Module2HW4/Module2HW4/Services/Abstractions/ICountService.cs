using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Services;

namespace Module2HW4.Services.Abstractions
{
    public interface ICountService
    {
        public int[] QuantityOfDifferentTypes();
    }
}
