public class PelicanBird : BirdAnimal
{
    public double beak;
    public PelicanBird(string animalName, int animalAge, double animalWeight, double wingSpan, double birdBeakLength) : base(animalName,animalAge,animalWeight,wingSpan)
    {
        beak = birdBeakLength;
        Console.WriteLine("Pelican Bird class constructor called");
    }

    public override void DoSound()
    {
        //base.DoSound();
        Console.WriteLine("Pelican Bird sounds like chirping\n");
    }
}