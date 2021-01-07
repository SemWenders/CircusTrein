using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Container
    {
        public List<Animal> animals;
        public int Weight { get; set; }

        public Container()
        {
            animals = new List<Animal>();
            Weight = 0;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Weight += animal.Size;
        }
    }
}
