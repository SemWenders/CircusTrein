using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public int Size { get; private set; }
        public AnimalType AnimalType { get; private set; }

        public Animal(int size, AnimalType animalType)
        {
            this.Size = size;
            this.AnimalType = animalType;
        }

        public override string ToString()
        {
            return $"{AnimalType}-eating animal of size: {Size}";
        }
    }
}
