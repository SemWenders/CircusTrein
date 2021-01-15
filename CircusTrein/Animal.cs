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
        public AnimalType Type { get; private set; }

        public Animal(int size, AnimalType animalType)
        {
            this.Size = size;
            this.Type = animalType;
        }

        public override string ToString()
        {
            return $"{Type}-eating animal of size: {Size}";
        }

        public bool IsBig()
        {
            if (Size == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsMedium()
        {
            if (Size == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSmall()
        {
            if (Size == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsMeatEating()
        {
            if (Type == AnimalType.Meat)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPlantEating()
        {
            if (Type == AnimalType.Plants)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
