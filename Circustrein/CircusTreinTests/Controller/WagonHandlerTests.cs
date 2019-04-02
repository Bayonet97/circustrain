using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Scripts.Tests
{
    [TestClass()]
    public class WagonHandlerTests
    {
        private Train train;
        private WagonHandler wagonHandler;

        [TestInitialize()]
        public void InitiateTest()
        {
            train = new Train();
            wagonHandler = new WagonHandler();
        }

        [TestMethod()]
        public void FillWagonsTestCorrect()
        {
            train.SortAnimals(new Animal("Lion", AnimalSize.Medium, AnimalType.Carnivore));
            train.SortAnimals(new Animal("Lion", AnimalSize.Medium, AnimalType.Carnivore));
            train.SortAnimals(new Animal("Lion", AnimalSize.Medium, AnimalType.Carnivore));
            train.SortAnimals(new Animal("Lion", AnimalSize.Medium, AnimalType.Carnivore));
            train.SortAnimals(new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore));
            train.SortAnimals(new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore));
            train.SortAnimals(new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore));
            train.SortAnimals(new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore));

            wagonHandler.FillWagons(train);
            Assert.IsTrue(train.finishedWagons.Count + train.unfinishedWagons.Count == 4);
        }

        [TestMethod()]
        public void FillWagonsTestWrong()
        {
            train.finishedWagons.Add(new Wagon(new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore)));
            train.finishedWagons[0].AddAnimal(new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore));
            bool canBeAdded = train.finishedWagons[0].CanBeAdded(AnimalSize.Small);


            Assert.IsFalse(canBeAdded);
        }

        [TestMethod()]
        public void SeparateCarnivoresCorrect()
        {
            train.SortAnimals(new Animal("Lion", AnimalSize.Medium, AnimalType.Carnivore));
            train.SortAnimals(new Animal("Pig", AnimalSize.Medium, AnimalType.Herbivore));

            wagonHandler.FillWagons(train);

            Animal lion = train.unfinishedWagons[0].Animals[0];
            Animal pig = train.unfinishedWagons[1].Animals[0];

            Assert.IsTrue(train.unfinishedWagons.Count == 2 && lion == train.unfinishedWagons[0].Animals[0] && pig == train.unfinishedWagons[1].Animals[0]);
        }
    }
}