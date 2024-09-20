public class HorseAnimal : Animal
{
    public int lifeSpan { get; set; }
    public HorseAnimal(string animalName, int animalAge, double animalWeight, int lifeTimeSpan) : base(animalName, animalAge, animalWeight)
    {
        lifeSpan = lifeTimeSpan;
        Console.WriteLine("HorseAnimal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Horse sounds like neigh-neigh.");
    }
}