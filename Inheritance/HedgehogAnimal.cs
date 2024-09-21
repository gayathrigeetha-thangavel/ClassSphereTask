public class HedgehogAnimal : Animal
{
    public double noOfQuills;
    public HedgehogAnimal(string animalName, int animalAge, double animalWeight, double numOfQuills) : base(animalName, animalAge, animalWeight)
    {
        noOfQuills = numOfQuills;
        //Console.WriteLine("Hedgehog Animal class constructor called");
    }

    public override void DoSound()
    {
        Console.WriteLine("Hedgehog sounds like huffing and puffing.");
    }
}