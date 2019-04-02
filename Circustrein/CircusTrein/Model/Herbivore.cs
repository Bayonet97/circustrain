using CircusTrein.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Model
{
    class Herbivore : IHerbivore
    {
        public string Name { get; set; }
        public AnimalSize Size { get; set; }
        public AnimalType Type { get; } = AnimalType.Herbivore;

        public Herbivore(string name, AnimalSize size)
        {
            Name = name;
            Size = size;
        }

        public override string ToString()
        {
            return "Herbivore " + Size + " " + Name;
        }
    }
}
