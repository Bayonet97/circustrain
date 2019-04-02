using CircusTrein.Model;
using CircusTrein.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public static class TrainStation
    {
        public static INewAnimal CreateNewAnimal()
        {
            return new NewAnimal();
        }
        public static ILoader CreateWagonHandler(ITrain train)
        {
            return new WagonHandler(train);
        }
        public static ITrain CreateTrain()
        {
            return new Train();
        }
        public static IWagon CreateWagon(IAnimal animal)
        {
            return new Wagon(animal);
        }
        public static ICarnivore CreateCarnivore(string name, AnimalSize size)
        {
            return new Carnivore(name,size);
        }
        public static IHerbivore CreateHerbivore(string name, AnimalSize size)
        {
            return new Herbivore(name, size);
        }
    }
}
