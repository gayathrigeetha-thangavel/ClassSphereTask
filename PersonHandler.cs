
public class PersonHandler
{

    public void SetAge(Person person, int age)
    {
        person.Age = age;
    }

    public Person CreatePerson(string fname, string lname, int age, double height, double weight)
    {
        Person p = new Person();
        p.FirstName = fname;
        p.LastName = lname;
        p.Age = age; 
        p.Height = height;
        p.Weight = weight;    
        return p;
    }

    public void HandlerClassPrint(Person person)
    {
        Console.WriteLine("Person details from Handler class:");
        Console.WriteLine("FirstName:"+person.FirstName+" LastName:"+person.LastName+" age:"+person.Age+" Height:"+person.Height+" Weight:"+person.Weight);
    }

    
}