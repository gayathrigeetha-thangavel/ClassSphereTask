public class DogAnimal : Animal
{
    public bool hasTail { get; set; }
    public DogAnimal(string animalName, int animalAge, double animalWeight, bool hasTail) : base(animalName, animalAge, animalWeight)
    {
        this.hasTail = hasTail;
        Console.WriteLine("DogAnimal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Dog sounds like woff-woff.");
    }
}