using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Enums;
using Module2HW4.Models;
using Module2HW4.Models.Arthropods;
using Module2HW4.Models.Chordates.Birds;
using Module2HW4.Models.Chordates.Fishes;
using Module2HW4.Models.Chordates.Mammals.Artiodactyls;
using Module2HW4.Models.Chordates.Mammals.Rodents;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public AnimalProvider()
        {
            Animals = new Animal[]
            {
                new Arthropod
                {
                    Name = "Bullet Ant",
                    ArthropodClass = ArthropodClass.Insect,
                    Region = Regions.SouthAmerica,
                    IsListedInTheRedBook = false,
                    IsPoisonous = true
                },

                new Arthropod
                {
                    Name = "Poecilotheria striata spider",
                    ArthropodClass = ArthropodClass.Arachnids,
                    Region = Regions.Asia,
                    IsListedInTheRedBook = true,
                    IsPoisonous = true
                },

                new Arthropod
                {
                    Name = "Japanese spider crab",
                    ArthropodClass = ArthropodClass.Crustaceans,
                    Region = Regions.Asia,
                    IsListedInTheRedBook = true,
                    IsPoisonous = false
                },

                new Bird
                {
                    Name = "Silkie hen",
                    Region = Regions.Asia,
                    IsListedInTheRedBook = false,
                    IsCanFly = false,
                    Habitat = HabitatsOfAnimals.Land
                },

                new Bird
                {
                    Name = "Black stork",
                    Region = Regions.Europe,
                    IsListedInTheRedBook = true,
                    IsCanFly = true,
                    Habitat = HabitatsOfAnimals.Land
                },

                new Fish
                {
                    Name = "Piranha",
                    Region = Regions.SouthAmerica,
                    IsListedInTheRedBook = false,
                    Habitat = HabitatsOfAnimals.Water,
                    TypeOfWater = TypeOfWater.Freshwater
                },

                new Fish
                {
                    Name = "Butterfly fish",
                    Region = Regions.CentralAfrica,
                    IsListedInTheRedBook = false,
                    Habitat = HabitatsOfAnimals.Water,
                    TypeOfWater = TypeOfWater.Marine
                },

                new Rodent
                {
                    Name = "American Hare",
                    Region = Regions.NorthAmerica,
                    IsListedInTheRedBook = false,
                    Habitat = HabitatsOfAnimals.Land,
                    IsHaveTeeth = true,
                    Family = FamilyOfRodents.Hare
                },

                new Rodent
                {
                    Name = "Flying squirrel",
                    Region = Regions.Asia,
                    IsListedInTheRedBook = true,
                    Habitat = HabitatsOfAnimals.Land,
                    IsHaveTeeth = true,
                    Family = FamilyOfRodents.Squirrels
                },

                new Rodent
                {
                    Name = "Harvest mouse",
                    Region = Regions.Europe,
                    IsListedInTheRedBook = false,
                    Habitat = HabitatsOfAnimals.Land,
                    IsHaveTeeth = true,
                    Family = FamilyOfRodents.Mouse
                },

                new Artiodactyl
                {
                    Name = "Axis",
                    Region = Regions.Asia,
                    IsListedInTheRedBook = false,
                    Habitat = HabitatsOfAnimals.Land,
                    IsHaveHorns = true,
                    IsHaveTeeth = true
                },

                new Artiodactyl
                {
                    Name = "Giant ant-eater",
                    Region = Regions.SouthAmerica,
                    IsListedInTheRedBook = true,
                    Habitat = HabitatsOfAnimals.Land,
                    IsHaveHorns = false,
                    IsHaveTeeth = false
                },

                new Artiodactyl
                {
                    Name = "Lama",
                    Region = Regions.SouthAmerica,
                    IsListedInTheRedBook = true,
                    Habitat = HabitatsOfAnimals.Land,
                    IsHaveHorns = false,
                    IsHaveTeeth = true
                }
            };
        }

        public Animal[] Animals { get; }
    }
}
