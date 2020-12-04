using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Animal
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
            return $"{AnimalType}-etend dier van formaat: {Size}";
        }
    }
}
