using System.Collections.Generic;

namespace CircusTrein
{
    public interface ITrain
    {
        List<IAnimal> UnassignedAnimals { get; set; }
        List<IWagon> UnfinishedWagons { get; set; }
        List<IWagon> FinishedWagons { get; set; }
        int Compare(IAnimal x, IAnimal y);
        void SortAnimals(IAnimal a);
    }
}