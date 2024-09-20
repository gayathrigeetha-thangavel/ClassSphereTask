
public class WolfAnimal : Animal
{

    public double runningSpeed;
    public WolfAnimal(string animalName, int animalAge, double animalWeight, double speed) : base(animalName, animalAge, animalWeight)
    {
        runningSpeed = speed;
        Console.WriteLine("Wolf animal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Wolf sounds like howl.");
    }
}