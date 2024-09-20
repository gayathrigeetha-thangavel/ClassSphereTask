public class BirdAnimal : Animal
{
    public double wingSpan;

    public BirdAnimal(string animalName, int animalAge, double animalWeight, double wingLength) : base(animalName, animalAge, animalWeight)
    {
        wingSpan = wingLength;
        Console.WriteLine("Bird animal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Bird sounds like chirping\n");
    }
}