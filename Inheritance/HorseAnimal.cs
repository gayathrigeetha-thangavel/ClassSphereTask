public class HorseAnimal : Animal
{
    public string breed;
    public HorseAnimal(string animalName, int animalAge, double animalWeight, string breed) : base(animalName, animalAge, animalWeight)
    {
        this.breed = breed;
        //Console.WriteLine("HorseAnimal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Horse sounds like neigh-neigh.");
    }
}