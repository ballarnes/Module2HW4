using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class CountService : ICountService
    {
        private readonly ISectionProvider _sectionProvider;

        public CountService(ISectionProvider sectionProvider)
        {
            _sectionProvider = sectionProvider;
        }

        public int[] QuantityOfDifferentTypes()
        {
            int[] quantityOfDifferentTypes = new int[6];
            string[] names = new string[_sectionProvider.AnimalsInSection.Length];
            for (var i = 0; i < _sectionProvider.AnimalsInSection.Length; i++)
            {
                names[i] = _sectionProvider.AnimalsInSection[i].GetType().Name;
            }

            for (var i = 0; i < _sectionProvider.AnimalsInSection.Length; i++)
            {
                if (names[i] == "Arthropod")
                {
                    quantityOfDifferentTypes[0]++;
                }
                else if (names[i] == "Bird")
                {
                    quantityOfDifferentTypes[1]++;
                }
                else if (names[i] == "Fish")
                {
                    quantityOfDifferentTypes[2]++;
                }
                else if (names[i] == "Artiodactyl")
                {
                    quantityOfDifferentTypes[3]++;
                }
                else
                {
                    quantityOfDifferentTypes[4]++;
                }
            }

            for (var i = 0; i < quantityOfDifferentTypes.Length - 1; i++)
            {
                if (quantityOfDifferentTypes[i] != 0)
                {
                    quantityOfDifferentTypes[5]++;
                }
            }

            return quantityOfDifferentTypes;
        }
    }
}
