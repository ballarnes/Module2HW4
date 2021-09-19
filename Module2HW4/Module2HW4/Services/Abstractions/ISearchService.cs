using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface ISearchService
    {
        public abstract Animal Search(Animal[] animals, string param);
    }
}
