using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Container
    {
        public List<Animal> animals;
        public int Weight { get; set; }
        public int MaxWeight { get; private set; }

        public Container(int maxWeight = 0)
        {
            animals = new List<Animal>();
            Weight = 0;
            this.MaxWeight = maxWeight;
        }
    }
}
