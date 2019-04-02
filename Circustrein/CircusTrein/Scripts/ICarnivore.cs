using CircusTrein.Model;

namespace CircusTrein.Scripts
{
    public interface ICarnivore : IAnimal
    {
        bool EatsAnimal(AnimalSize animaltoEatSize);
    }
}
