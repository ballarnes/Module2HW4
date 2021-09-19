using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public static class AnimalExtension
    {
        public static Animal FindAnimalByName(this Animal[] animals, string name)
        {
            Animal foundAnimal = null;
            for (var i = 0; i < animals.Length; i++)
            {
                if (animals[i].Name == name || animals[i].Name.ToLower() == name)
                {
                    foundAnimal = animals[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return foundAnimal;
        }
    }
}