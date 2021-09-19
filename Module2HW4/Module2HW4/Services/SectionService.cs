using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Providers;
using Module2HW4.Helpers;

namespace Module2HW4.Services
{
    public class SectionService : ISectionService
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly ISectionProvider _sectionProvider;

        public SectionService(IAnimalProvider animalProvider, ISectionProvider sectionProvider)
        {
            _animalProvider = animalProvider;
            _sectionProvider = sectionProvider;
        }

        public void AddToSection()
        {
            const int maxAnimalsInSection = 20;
            Animal[] animals = new Animal[maxAnimalsInSection];
            for (var i = 0; i < animals.Length; i++)
            {
                animals[i] = _animalProvider.Animals[new Random().Next(0, 13)];
                _sectionProvider.AnimalsInSection = animals;
            }
        }

        public void SortAnimalsByName()
        {
            Array.Sort(_sectionProvider.AnimalsInSection, new AnimalComparer());
        }
    }
}
