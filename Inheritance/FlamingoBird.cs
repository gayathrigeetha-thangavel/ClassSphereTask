public class FlamingoBird : BirdAnimal
{
    public string color;
    public FlamingoBird(string animalName, int animalAge, double animalWeight, double wingSpan, string animalColor) : base(animalName,animalAge,animalWeight,wingSpan)
    {
        color = animalColor;
        Console.WriteLine("Flamingo bird class constructor called");
    }

    public override void DoSound()
    {
        //base.DoSound();
        Console.WriteLine("Flamingo bird sounds like grunting or growling\n");
    }
}