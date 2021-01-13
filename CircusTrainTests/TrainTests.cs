using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;

namespace CircusTrainTests
{
    [TestClass]
    public class TrainTests
    {
        /// <summary>
        /// This test-method is mainly made to test wether the methods work
        /// This test-method still makes use of the old algorithm
        /// </summary>
        [TestMethod]
        public void CheckAlgorithm()
        {
            Train train = new Train();
            for (int i = 0; i < 3; i++)
            {
                Animal animal = new Animal(3, AnimalType.Plants);
                train.AddAnimal(animal);
            }

            Animal meatAnimal1 = new Animal(3, AnimalType.Meat);
            train.AddAnimal(meatAnimal1);

            Animal plantAnimal1 = new Animal(5, AnimalType.Plants);
            train.AddAnimal(plantAnimal1);

            Animal meatAnimal2 = new Animal(3, AnimalType.Meat);
            train.AddAnimal(meatAnimal2);

            Animal plantAnimal2 = new Animal(1, AnimalType.Plants);
            train.AddAnimal(plantAnimal2);

            Assert.AreEqual(3, train.GetContainers().Count);
        }

        /// <summary>
        /// This test-method is written to test the new improved algorithm
        /// The old algorithm worked quite well, but simply added the animals in order to the containers
        /// The new algorithm first adds the biggest animals
        /// With the old algorithm this test-method would take up three containers, this only uses two
        /// </summary>
        [TestMethod]
        public void CheckOptimalContainerUsage()
        {
            Train train = new Train();

            Animal animal1 = new Animal(5, AnimalType.Plants);
            Animal animal2 = new Animal(3, AnimalType.Plants);
            Animal animal3 = new Animal(5, AnimalType.Plants);
            Animal animal4 = new Animal(3, AnimalType.Plants);
            Animal animal5 = new Animal(3, AnimalType.Plants);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);

            train.AddAnimals(animals);

            Assert.AreEqual(2, train.GetContainers().Count);
        }
    }
}
