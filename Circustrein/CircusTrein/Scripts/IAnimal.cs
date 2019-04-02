namespace CircusTrein
{
    public enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Large = 5
    };

    public enum AnimalType
    {
        Herbivore,
        Carnivore
    };

    public interface IAnimal
    {
        string Name { get; set; }
        AnimalSize Size { get; set; }

        AnimalType Type { get; }
        
        string ToString();
    }
}