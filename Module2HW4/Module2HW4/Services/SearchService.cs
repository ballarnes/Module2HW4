using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public abstract class SearchService : ISearchService
    {
        public abstract Animal Search(Animal[] animals, string param);
    }
}
