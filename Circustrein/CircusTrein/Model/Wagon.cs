using CircusTrein.Scripts;
using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class Wagon : IWagon
    {
        private List<IAnimal> animals = new List<IAnimal>();
        private readonly int capacity = 10;
        private static int wagonCounter;
        
        public List<IAnimal> Animals
        {
            get { return animals; }
            set { animals = Animals; }
        }

        public int Id { get; private set; }
        public int RemainingSpace { get; private set; }

        public Wagon(IAnimal animal)
        { 
            Id = ++wagonCounter;
            RemainingSpace = capacity - (int)animal.Size;
            animals.Add(animal);
        }

        public bool CanBeAdded(AnimalSize size)
        {
           return !((int)size > RemainingSpace || HasCarnivoreLargerOrEqualTo(size));
        }

        public bool HasCarnivoreLargerOrEqualTo(AnimalSize size)
        {
            // Find carnivore in wagon, if there is a carnivore, check if it eats the animal we try to add.
            if (Animals.Find(animal => animal is ICarnivore) is ICarnivore carnivoreInWagon)
            {
                if (carnivoreInWagon.EatsAnimal(size))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
            RemainingSpace -= (int)animal.Size;

            return RemainingSpace == 0 || HasCarnivoreLargerOrEqualTo(animal.Size);
        }

        public override string ToString()
        {
            return "Wagon " + Id;
        }
    }
}
