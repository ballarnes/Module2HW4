using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;
using Module2HW4.Providers;
using Module2HW4.Services;
using Module2HW4.Models;
using Module2HW4.Services.SearchServices;

namespace Module2HW4
{
    public class AppStarter
    {
        private readonly ISectionProvider _sectionProvider;
        private readonly ISectionService _sectionService;
        private readonly ICountService _countService;
        private readonly ISearchService _searchService;

        public AppStarter(ISectionProvider sectionProvider, ISectionService sectionService, ICountService countService, ISearchService searchService)
        {
            _sectionProvider = sectionProvider;
            _sectionService = sectionService;
            _countService = countService;
            _searchService = searchService;
        }

        public void Start()
        {
            _sectionService.AddToSection();
            _sectionService.SortAnimalsByName();

            Console.WriteLine("All animals in section:");
            Console.WriteLine("=======================");

            for (var i = 0; i < _sectionProvider.AnimalsInSection.Length; i++)
            {
                Console.WriteLine(_sectionProvider.AnimalsInSection[i].Name);
            }

            Console.WriteLine("=======================");

            int[] quantityOfDifferentTypes = _countService.QuantityOfDifferentTypes();
            Console.WriteLine($"The number of different types of animals in the section: {quantityOfDifferentTypes[5]}. Namely:");
            Console.WriteLine($"Arthropods:\t{quantityOfDifferentTypes[0]};");
            Console.WriteLine($"Birds:\t\t{quantityOfDifferentTypes[1]};");
            Console.WriteLine($"Fishes:\t\t{quantityOfDifferentTypes[2]};");
            Console.WriteLine($"Artiodactyls:\t{quantityOfDifferentTypes[3]};");
            Console.WriteLine($"Rodents:\t{quantityOfDifferentTypes[4]}.");
            Console.WriteLine("=======================");

            Console.WriteLine("Type the name of the animal you want to find:");
            string name = Console.ReadLine();
            Animal foundByNameAnimal = _searchService.Search(_sectionProvider.AnimalsInSection, name);
            if (foundByNameAnimal != null)
            {
                Console.WriteLine("=======================");
                Console.WriteLine($"Name: {foundByNameAnimal.Name}; Region: {foundByNameAnimal.Region}; Is listed in the Red Book: {foundByNameAnimal.IsListedInTheRedBook}.");
            }
            else
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Animal wasn't found");
            }
        }
    }
}
