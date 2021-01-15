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

        public bool IsAnimalAble(Animal animal)
        {
            if (Weight + animal.Size <= 10)
            {
                if (animal.IsMeatEating())
                {
                    return IsMeatAnimalAble(animal, animals);
                }
                else
                {
                    return IsPlantAnimalAble(animal, animals);
                }
            }
            else
            {
                //the animal doesn't fit
                return false;
            }
        }

        private bool IsMeatAnimalAble(Animal newAnimal, List<Animal> animalsInContainer)
        {
            foreach (var animalInContainer in animalsInContainer)
            {
                //there can only be one meat eating animal in a container
                if (animalInContainer.IsMeatEating())
                {
                    return false;
                }

                //all the other animals in the container have to be bigger than the new meat eating animal
                else if (animalInContainer.IsPlantEating() && newAnimal.Size >= animalInContainer.Size)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPlantAnimalAble(Animal newAnimal, List<Animal> animalsInContainer)
        {
            foreach (var animalInContainer in animalsInContainer)
            {
                if (animalInContainer.IsMeatEating() && animalInContainer.Size >= newAnimal.Size)
                {
                    //the new animal would be eaten
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }
    }
}
