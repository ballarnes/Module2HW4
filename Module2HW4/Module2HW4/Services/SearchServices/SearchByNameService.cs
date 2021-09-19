using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;
using Module2HW4.Helpers;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services.SearchServices
{
    public class SearchByNameService : SearchService, ISearchService
    {
        public override Animal Search(Animal[] animals, string param)
        {
            Animal foundAnimal = animals.FindAnimalByName(param);
            return foundAnimal;
        }
    }
}
