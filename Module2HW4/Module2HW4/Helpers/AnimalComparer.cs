using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal s1, Animal s2)
        {
            if (s1.Name.Length > s2.Name.Length)
            {
                return 1;
            }
            else if (s1.Name.Length < s2.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
