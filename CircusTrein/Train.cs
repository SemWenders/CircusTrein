using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        List<Container> containers;

        public Train()
        {
            containers = new List<Container>();
        }

        public List<Container> GetContainers()
        {
            return containers;
        }

        public void ClearTrain()
        {
            containers.Clear();
        }

        public void AddContainer(Container container)
        {
            containers.Add(container);
        }
        
        public void AddAnimal(Animal animal)
        {
            if (containers == null)
            {
                Container container = new Container();
                containers.Add(container);
            }

            foreach (var container in containers)
            {
                if (container.Weight + animal.Size <= 10)
                {
                    bool addAnimalToContainer = true;
                    foreach (var animalInContainer in container.animals)
                    {
                        if (animal.AnimalType == AnimalType.Meat)
                        {
                            //if the new animal is a meat eater, all other animals must be plant eaters and need to be bigger
                            if (animalInContainer.AnimalType == AnimalType.Meat)
                            {
                                //only one meat-eating animal is allowed in a container
                                addAnimalToContainer = false;
                            }
                            if (animalInContainer.AnimalType == AnimalType.Plants && animalInContainer.Size <= animal.Size)
                            {
                                //if there's an animal in the container smaller or equal the size of the new animal, it will get eaten, so go to the next container
                                addAnimalToContainer = false;
                            }
                        }

                        //if the new animal is a plant eater, it should be bigger than any meat eating animals in the container (if there are any)
                        else if (animal.AnimalType == AnimalType.Plants)
                        {
                            if (animalInContainer.AnimalType == AnimalType.Meat && animalInContainer.Size >= animal.Size)
                            {
                                //if there's a meat-eating animal in the container, that's bigger or the same size as the new animal, go to the next container
                                addAnimalToContainer = false;
                            }
                        }
                    }
                    if (addAnimalToContainer)
                    {
                        //if the new animal meets the requirements, add it to the container and exit the method
                        container.AddAnimal(animal);
                        return;
                    }
                }
            }

            //if the animal didn't meet all the requirements, or it didn't fit in any of the containers, make a new container
            Container newContainer = new Container();
            containers.Add(newContainer);
            newContainer.AddAnimal(animal);
            return;
        }
    }
}
