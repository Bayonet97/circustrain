using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train : IComparer<IAnimal>, ITrain
    {
        public List<IAnimal> UnassignedAnimals { get; set; } = new List<IAnimal>();
        public List<IWagon> UnfinishedWagons { get; set; } = new List<IWagon>();
        public List<IWagon> FinishedWagons { get; set; } = new List<IWagon>();

        public void SortAnimals(IAnimal a)
        {
            UnassignedAnimals.Add(a);

            // Sort the AnimalList.
            UnassignedAnimals.Sort(Compare);
        }


        public int Compare(IAnimal x, IAnimal y)
        {
            int result;

            if (ReferenceEquals(x, y))
            {
                result = 0;
            }
            else
            {
                if (x == null)
                {
                    result = -1;
                }
                else if (y == null)
                {
                    result = 1;
                }
                else
                {
                    result = TypeCompare(x.Type, y.Type);

                    if (result == 0)
                    {
                        result = SizeCompare(x.Size, y.Size);     

                        if (result == 0)
                        {
                            NameCompare(x.Name, y.Name);
                        }
                    }
                }
            }
            return result;
        }

        private int SizeCompare(AnimalSize sizeX, AnimalSize sizeY)
        {
            if (sizeX == sizeY)
            {
                return 0;
            }
            else if (sizeX > sizeY)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
        private int TypeCompare(AnimalType typeX, AnimalType typeY)
        {
            if (typeX == typeY)
            {
                return 0;
            }
            else if (typeX == AnimalType.Carnivore)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }

        private int NameCompare(string nameX, string nameY)
        {
            if (nameX == null)
            {
                if (nameY == null)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return nameX.CompareTo(nameY);
            }
        }

    }
}
