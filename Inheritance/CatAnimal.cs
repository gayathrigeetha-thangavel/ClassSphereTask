
public class CatAnimal : Animal
{

    public bool isExisted;
    public CatAnimal(string animalName, int animalAge, double animalWeight, bool isAlive) : base(animalName, animalAge, animalWeight)
    {
        isExisted = isAlive;
        //Console.WriteLine("Cat animal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Cat animal sounds like meow");
    }

    public override string Stats()
    {
        return $"{base.Stats()}, Statistics: {IsExistedAnimal(isExisted)}";
    }

    private static string IsExistedAnimal(bool isAlive)
    {
        if (isAlive)
        {
            return "Existed animal";
        }
        else
        {
            return "Non-Existed animal";
        }
    }
}