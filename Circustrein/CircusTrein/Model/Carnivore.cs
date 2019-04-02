using CircusTrein.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Model
{
    class Carnivore : ICarnivore
    {
        public string Name { get; set; }

        public AnimalSize Size { get; set; }
        public AnimalType Type { get; } = AnimalType.Carnivore;

        public Carnivore(string name, AnimalSize size)
        {
            Name = name;
            Size = size;
        }

        public bool EatsAnimal(AnimalSize animalToEatSize)
        {
            if(Size >= animalToEatSize)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Carnivore " + Size + " " + Name;
        }
    }
}
