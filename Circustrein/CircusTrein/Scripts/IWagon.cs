using System.Collections.Generic;

namespace CircusTrein
{
    public interface IWagon
    {
        List<IAnimal> Animals { get; set; }
        int Id { get; }
        int RemainingSpace { get; }

        bool AddAnimal(IAnimal animal);
        bool CanBeAdded(AnimalSize size);
        bool HasCarnivoreLargerOrEqualTo(AnimalSize size);
        string ToString();
    }
}