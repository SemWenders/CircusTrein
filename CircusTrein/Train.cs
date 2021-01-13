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
            foreach (var container in containers)
            {
                if (container.IsAnimalAble(animal))
                {
                    container.AddAnimal(animal);
                    return;
                }
            }

            //if the animal didn't meet all the requirements, or it didn't fit in any of the containers, make a new container
            Container newContainer = new Container();
            containers.Add(newContainer);
            newContainer.AddAnimal(animal);
        }

        public void AddAnimals(List<Animal> animals)
        {
            //to ensure we use as little containers as possible, we first have to add the biggest animals, so that
            //we are as efficient with our space as possible
            AddBigAnimals(animals);

            AddMediumAnimals(animals);

            AddSmallAnimals(animals);
        }

        private void AddBigAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.Size == 5)
                {
                    AddAnimal(animal);
                }
            }
        }

        private void AddMediumAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.Size == 3)
                {
                    AddAnimal(animal);
                }
            }
        }

        private void AddSmallAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.Size == 1)
                {
                    AddAnimal(animal);
                }
            }
        }
    }
}
