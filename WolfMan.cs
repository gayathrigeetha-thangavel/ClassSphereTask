public class WolfMan : WolfAnimal, IPerson
{

    public WolfMan(string animalName, int animalAge, double animalWeight, double speed) : base(animalName, animalAge, animalWeight, speed)
    {
        Console.WriteLine("\nWolfMan class constructor called");
    }

    public override void DoSound()
    {
        base.DoSound();
    }

    public void Talk()
    {
        Console.WriteLine("The wolfman speaks in a gruff voice and he transforming into a wolf!");
    }
}