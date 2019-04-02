using CircusTrein.Model;
using CircusTrein.Scripts;
using System;
using System.Windows.Forms;

namespace CircusTrein
{
    public class NewAnimal : INewAnimal
    {
        //Call function with given values, return new Animal to add to list.
        public void ConvertToAnimal(object name, object sizeSelection, object typeSelection, ITrain train)
        {
            string convertedName = name.ToString();
            AnimalSize convertedSize = ConvertSizeSelectionToAnimalSize(sizeSelection.ToString());
            AnimalType convertedType = ConvertTypeSelectionToAnimalType(typeSelection.ToString());

            AddAnimal(convertedName, convertedSize, convertedType, train);
        }

        private AnimalSize ConvertSizeSelectionToAnimalSize(string size)
        {
            // Take the text on given size selection to determine the size to return.
            switch (size)
            {
                case "Small (1)":
                    return AnimalSize.Small;

                case "Medium (3)":
                    return AnimalSize.Medium;

                case "Large (5)":
                    return AnimalSize.Large;

                default:
                    throw new System.ArgumentNullException();
            }

        }

        private AnimalType ConvertTypeSelectionToAnimalType(string typeSelection)
        {
            switch (typeSelection)
            {
                case "Herbivore":
                    return AnimalType.Herbivore;
                case "Carnivore":
                    return AnimalType.Carnivore;
                default:
                    throw new ArgumentNullException();
            }
        }

        private void AddAnimal(string name, AnimalSize size, AnimalType type, ITrain train)
        {
            IAnimal newAnimal;
            if(type == AnimalType.Carnivore)
            {
                newAnimal = TrainStation.CreateCarnivore(name, size);
                train.SortAnimals(newAnimal);
            }
            if(type == AnimalType.Herbivore)
            {
                newAnimal = TrainStation.CreateHerbivore(name, size);
                train.SortAnimals(newAnimal);
            }           
        }
    }
}
