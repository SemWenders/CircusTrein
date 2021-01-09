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
                foreach (var animalInContainer in animals)
                {
                    if (animal.AnimalType == AnimalType.Meat)
                    {
                        //there can only be one meat eating animal in a container
                        if (animalInContainer.AnimalType == AnimalType.Meat)
                        {
                            return false;
                        }

                        else if (animalInContainer.AnimalType == AnimalType.Plants && animal.Size >= animalInContainer.Size)
                        {
                            //all the other animals in the container have to be bigger than the new meat eating animal
                            return false;
                        }
                    }

                    else if (animal.AnimalType == AnimalType.Plants)
                    {
                        if (animalInContainer.AnimalType == AnimalType.Meat && animalInContainer.Size >= animal.Size)
                        {
                            //the new animal would be eaten
                            return false;
                        }
                    }
                }
                //if the animal meets all the requirements, return true
                return true;
            }
            else
            {
                //the animal doesn't fit
                return false;
            }
        }
    }
}
