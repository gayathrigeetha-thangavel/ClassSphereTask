public abstract class Animal
{

    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; } 
   


    protected Animal(string animalName, int animalAge, double animalWeight)
    {
        Name = animalName;
        Age = animalAge;
        Weight = animalWeight;
    }

    public abstract void DoSound();
}