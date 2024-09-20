public class Person
{
    private int age;
    private double height;
    private double weight;


    // get , set property methods
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public int Age
    {
        get { return age ; }
        set { age = value ; } 
    }

    public double Height
    {
        get { return height ; }
        set { height = value ; } 
    }

    public double Weight
    {
        get { return weight ; }
        set { weight = value ; } 
    }

}