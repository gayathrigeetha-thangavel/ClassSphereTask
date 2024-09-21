public class WolfMan : WolfAnimal, IPerson
{

    public string hasPointyEars;
    public WolfMan(string animalName, int animalAge, double animalWeight, double speed, string hasPointyEar) : base(animalName, animalAge, animalWeight, speed)
    {
        this.hasPointyEars = hasPointyEar;
    }

    public override void DoSound()
    {
        base.DoSound();
    }

    public void Talk()
    {
        Console.WriteLine("The wolfman speaks in a gruff voice and he transforming into a wolf!");
    }

    public override string Stats()
    {
        return $"{base.Stats()}, Has Pointy Ears: {hasPointyEars}";
    }
}