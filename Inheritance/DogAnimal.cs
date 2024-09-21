public class DogAnimal : Animal
{
    public string breed;
    public DogAnimal(string animalName, int animalAge, double animalWeight, string animalBreed) : base(animalName, animalAge, animalWeight)
    {
        breed = animalBreed;
        //Console.WriteLine("DogAnimal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Dog sounds like woff-woff.");
    }

    public override string Stats()
    {
        return $"{base.Stats()}, breed: {breed}";
    }

    public string GetOptionalName(string optionalString)
    {
        if (string.IsNullOrWhiteSpace(optionalString))
        {
            return "No optional name provided";
        }
        return optionalString;
    }
}