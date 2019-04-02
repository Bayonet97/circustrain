using AlgoritmiekProject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CircusTrein.Scripts
{
    public class WagonHandler : ILoader
    {
        private ITrain _train;
        private IAnimal _animal;
        public WagonHandler(ITrain train)
        {
            _train = train;
        }
        public void Load()
        {
            foreach (IAnimal animal in _train.UnassignedAnimals)
            {
                _animal = animal;
                AssignAnimalToWagon();
            }
            _train.UnassignedAnimals.Clear();
        }

        private void AssignAnimalToWagon()
        {
            if (_animal.Type == AnimalType.Herbivore && _train.UnfinishedWagons.Count != 0)
            {
                // If animal is larger than the remaining space of the wagon or has a carnivore equal or greater than the animal, check next wagon.
                int index = _train.UnfinishedWagons.FindIndex(x => x.CanBeAdded(_animal.Size));

                if(index != -1)
                {
                    bool wagonFinished = _train.UnfinishedWagons[index].AddAnimal(_animal);

                    if (wagonFinished)
                    {
                        _train.FinishedWagons.Add(_train.UnfinishedWagons[index]);
                        _train.UnfinishedWagons.RemoveAt(index);                       
                    }
                    return;
                }  
            }
            AddNewWagon();
        }

        private void AddNewWagon()
        {
            if (_animal.Type == AnimalType.Carnivore && _animal.Size == AnimalSize.Large)
            {
                _train.FinishedWagons.Add(TrainStation.CreateWagon(_animal));
            }
            else
            {
                _train.UnfinishedWagons.Add(TrainStation.CreateWagon(_animal));
            }
        }
    }
}