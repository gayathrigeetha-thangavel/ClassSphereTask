public class WormAnimal : Animal
{
    public bool hasEars;
    public WormAnimal(string name, int age, double weight, bool hasEars) : base(name, age, weight)
    {
        this.hasEars  = hasEars;
        //Console.WriteLine("Worm Animal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Worm doesn't produce any sounds.");
    }

    public string checkHasEars(bool hasEars)
    {
        if (hasEars)
        {
            return "It has ears";
        }
        else
        {
            return "It has no ears";
        }
    }
}