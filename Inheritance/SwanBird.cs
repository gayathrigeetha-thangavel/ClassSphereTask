public class SwanBird : BirdAnimal
{
    public string foodType;
    public SwanBird(string animalName, int animalAge, double animalWeight, double wingSpan, string birdFoodType) : base(animalName,animalAge,animalWeight,wingSpan)
    {
        foodType = birdFoodType;
        Console.WriteLine("Swan Bird class constructor called");
    }

    public override void DoSound()
    {
        //base.DoSound();
        Console.WriteLine("Swan Bird sounds like a short snoring quack and a muffled honk\n");
    }
}