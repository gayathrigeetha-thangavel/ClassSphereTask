using System.Text.RegularExpressions;

internal partial class Program
{
    private static Person? pObj = null;
    private static void Main(string[] args)
    {
       
        //instantiate process begins...
        Person person = new Person();
        PersonHandler personHandler = new PersonHandler();
        
        //Main menu started here...
        Console.WriteLine("Hello, Welcome to the OOPS concepts:");
        int input = 0;
        do
        {
            mainMenu();
            input = getChoice();
            executeUserChoice(input, personHandler);
        }while (input != 0);      
        
    }

    //display the main menu input choices to select by the user 
    public static void mainMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1: Create Person");
        Console.WriteLine("2: Display the person");
        Console.WriteLine("3: Show individual animal statistics");
        Console.WriteLine("4: Animal List");
        Console.WriteLine("5: Dog List");
        Console.WriteLine("0: Quit");
    }

    //get the choices from the user 
    public static int getChoice()
    {
        Console.WriteLine("Enter your choice:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        return userInput;
    }


    public static void executeUserChoice(int choice, PersonHandler personHandler)
    {
        switch (choice)
        {
            case 0:
                Console.WriteLine("Exiting...");
                break;
            case 1:
                createThePerson();
                break;
            case 2:
                displayThePerson(personHandler, pObj);
                break;
            case 3:
                showTheDifferentTypesOfAnimals();
                break;
            case 4:
                listDifferentAnimalsAndChartertics();
                break;
            case 5:
                listDifferentDogsAndChartertics(); 
                break;
            default:
                Console.WriteLine("Choose only 1 to 5 options");
                break;
        }
    }


    // Case 1: create the persoon with different type of validations are executed

    private static void createThePerson()
    {
        PersonHandler personHandler = new PersonHandler();

        //get user inputs from prompt
        Console.WriteLine("Enter the person details:");
        Console.WriteLine("Enter the First Name:");
        string? fName = Console.ReadLine();

        Console.WriteLine("Enter the Last Name:");
        string? lName = Console.ReadLine();

        Console.WriteLine("Enter the age:");
        string? ageInput = Console.ReadLine();

        Console.WriteLine("Enter the height:");
        string? heightInput= Console.ReadLine();

        Console.WriteLine("Enter the weight:");
        string? weightInput= Console.ReadLine();
        



        //validate the input value and convert into an integer with custom errors
        if (!int.TryParse(ageInput, out int age))
        {
            UserError userError = new TextInputError();
            Console.WriteLine(userError.UEMessage());
        }

        //validate the input value and convert into a double
        if (!double.TryParse(heightInput, out double height))
        {
            UserError userError = new TextInputError();
            Console.WriteLine(userError.UEMessage());
        }

        if (!double.TryParse(weightInput, out double weight))
        {
            UserError userError = new TextInputError();
            Console.WriteLine(userError.UEMessage());
        }



        //validate inputs using List. Add the errors in the list and display the errors.
        List<string> validationErrors = validateInputErrorUsingList(fName!, lName!, age, height, weight);

        if (validationErrors.Count  == 0)
        {
            Console.WriteLine("All inputs are valid");
            pObj = personHandler.CreatePerson(fName!, lName!, age, height, weight);
            Console.WriteLine("User Created Successfully");
            personHandler.HandlerClassPrint(pObj);
        }
        else
        {
            Console.WriteLine("The following validation errors occurred:");
            foreach (var error in validationErrors)
            {
                Console.WriteLine($"- {error}");
            }
        }


        //check all the values are valid or not
        /**

        bool isFirstNameValid = false;
        bool isLastNameValid = false;
        bool isAgeValid = false;
        try
        {
            if (fName != null){
                bool isValid = ValidateFirstName(fName);
                if (isValid)
                {
                    isFirstNameValid = true;
                    //person.FirstName = fName ;
                }      
            }
                  
        }
        catch(Exception ex)
        {
            Console.WriteLine("Validation Error:"+ ex.Message);
        }
       

        try
        {
            if (lName != null){
                bool isValid = ValidateLastName(lName);
                if (isValid)
                {
                    isLastNameValid = true;
                    //person.LastName = lName ;
                }      
            }
                  
        }
        catch(Exception ex)
        {
            Console.WriteLine("Validation Error:"+ ex.Message);
        }

        try
        {
            bool isValid = ValidateAge(age);
            if (isValid)
            {
                isAgeValid = true;
                personHandler.SetAge(person, age);
            }                 
        }
        catch(Exception ex)
        {
            Console.WriteLine("Validation Error:"+ ex.Message);
        }
       
        //person.Height = height;
        //person.Weight = weight;

        if (isFirstNameValid && isLastNameValid && isAgeValid)
        {
            Person pObj = personHandler.CreatePerson(fName!, lName!, age, height, weight);
            Console.WriteLine("User Created Successfully");
            return pObj;
        }
        else
        {
            Console.WriteLine("Some inputs are invalid.");
            return null!;
        }*/

    } 


    //Validation check for try - catch block: if it is not true then throw user defined exceptions
    private static bool ValidateFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException("First name cannot be null or empty");
        }
        
        if(firstName.Length < 2 || firstName.Length > 10)
        { 
            throw new ArgumentException("Firstname length must be between 2 to 10 long");
        }
        return true; 
    
    }

    //Validation check for try - catch block: if it is not true then throw user defined exceptions
    private static bool ValidateLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("LastName cannot be null or empty");
        }
        if (lastName.Length < 3 || lastName.Length > 15)
        {
            throw new ArgumentException("LastName length must be between 3 to 15 long"); 
        }
        return true;
    }

    //Validation check for try - catch block: if it is not true then throw user defined exceptions
    private static bool ValidateAge(int age)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Age should be greater than 0");
        }
        return true;  
    }

    // Method definition - validate and display the list of errors for all the inputs are given by the user.
    private static List<string> validateInputErrorUsingList(string firstName, string lastName, int ageInput, double height, double weight)
    {
        var errors = new List<string>();
        UserError userError;
        userError = new NumericInputError();

        // Validate first name
        if (string.IsNullOrWhiteSpace(firstName))
        {
            errors.Add("First name cannot be null or empty.");
        }
        else if (containsNumber(firstName))
        {
            errors.Add(userError.UEMessage());
        }
        else if (firstName.Length < 2 || firstName.Length > 10)
        {
            errors.Add("First name length must be between 2 and 10 characters.");
        }
        else if (containsSpecialCharcters(firstName))
        {
            userError = new SpecialCharInputError();
            errors.Add(userError.UEMessage());
        }

        // Validate last name
        if (string.IsNullOrWhiteSpace(lastName))
        {
            errors.Add("Last name cannot be null or empty.");
        }
        else if (containsNumber(lastName))
        {
            errors.Add(userError.UEMessage());
        }
        else if (lastName.Length < 3 || lastName.Length > 15)
        {
            errors.Add("Last name length must be between 3 and 15 characters.");
        }
        else if (containsSpecialCharcters(lastName))
        {
            userError = new SpecialCharInputError();
            errors.Add(userError.UEMessage());
        }

        // Validate age
        if (ageInput <= 0)
        {
            errors.Add("Age must be a valid positive number.");
        }


        // Validate height
        if (height <= 0)
        {
            errors.Add("Height must be a valid positive number.");
        }

        // Validate weight
        if (weight <= 0)
        {
            errors.Add("Weight must be a valid positive number.");
        }
        return errors;
    }


    // validation for if the input contains any number 
    private static bool containsNumber(string userInput)
    {
        foreach (char ch in userInput)
        {
            if (char.IsDigit(ch))
            {
                return true; 
            }
        }
        return false;
    }

    // validation for if the input contains any special characters
    private static bool containsSpecialCharcters(string userInput)
    {
        if (Regex.IsMatch(userInput, @"[^a-zA-Z0-9]"))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    // case 2: display the person details    
    private static void displayThePerson(PersonHandler personHandler, Person? pObj)
    {
        //call the handler class method to print the person deatils which is stored in person class using encapsulation
        if (pObj != null)
        {
            personHandler.HandlerClassPrint(pObj);
        }
        else
        {
            Console.WriteLine("No person created yet. Please create a person.");
        }
        
    }

    //Case 3: Showing different type of animal categories with sub menu
    private static void showTheDifferentTypesOfAnimals()
    {
        AnimalController animalController = new AnimalController();
        Console.WriteLine("\nWelcome to the Jungle");
        int input = 0;
        do
        {
            subMenu();
            input = getChoice();
            executeSubMenuUserChoice(input, animalController);
        }while (input != 0);      
    }

    private static void subMenu()
    {
        Console.WriteLine("\nAnimals Menu");
        Console.WriteLine("1: Horse");
        Console.WriteLine("2: Dog");
        Console.WriteLine("3: hedgehog");
        Console.WriteLine("4: Worm");
        Console.WriteLine("5: Bird");
        Console.WriteLine("6: Wolf");
        Console.WriteLine("0: Quit");
    }

    private static void executeSubMenuUserChoice(int input, AnimalController animalController)
    {
        switch (input)
        {
            case 0:
                Console.WriteLine("Exiting...");
                break;
            case 1:
                animalController.showHorseAnimal();
                break;
            case 2:
                animalController.showDogAnimal();
                break;
            case 3:
                animalController.showHedgehogAnimal(); 
                break;
            case 4:
                animalController.showWormAnimal();
                break;
            case 5:
                animalController.showBirdAnimal();
                break;
            case 6:
                animalController.showWolfAnimal();
                break; 
            case 7:
                animalController.showCatAnimal();
                break;
            default:
                Console.WriteLine("Choose only 1 to 6 options");
                break;
        }
    }

    // case 4: list all the animals
    private static void listDifferentAnimalsAndChartertics()
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(new BirdAnimal("Bird",20, 150, 3.5));
        animals.Add(new CatAnimal("Cat",18, 4.5, true));
        animals.Add(new HedgehogAnimal("Hedgehog", 1, 2,4000));
        animals.Add(new HorseAnimal("Horse", 30, 500, "Standard horse"));
        animals.Add(new WolfAnimal("Wolf", 16, 80, 40));
        animals.Add(new WolfMan("Wolf Man", 12, 70, 35, "Yes"));
        animals.Add(new WormAnimal("Worm",7, 0.25, false));
        animals.Add(new DogAnimal("Dog",13, 110, "Beagle"));

        //list the animal names
        Console.WriteLine("Animal names");
        foreach (Animal animal in animals)
        {
            Console.WriteLine ($"Name:{animal.Name}");
        }

        // list the animal sounds
        Console.WriteLine("\nAnimal sounds");
        foreach(Animal animal in animals)
        {
            if (animal is IPerson person)
            {
                person.Talk();
            }
            else
            {
                animal.DoSound();
            }
            
        }

        //list the animal stats : when we call the stats() method it will go the derived class and call the override method. 
        //During the override function print the values that will come from the both base class and dervied class

        Console.WriteLine("\nAnimal Statistics:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Stats());
            if (animal is DogAnimal dogAnimal)// this will print when the dog animal class instantiate
            {
                // check the possible option to get the optional name through dog animal class method
                Console.WriteLine($"Dog NickName:{dogAnimal.GetOptionalName("")}");
                Console.WriteLine($"Dog NickName:{dogAnimal.GetOptionalName("Scooby")}");
            }
        }
    }

    // case 5: List the different type of dogs
     private static void listDifferentDogsAndChartertics()
    {
        List<DogAnimal> dogs = new List<DogAnimal>();
        
        dogs.Add(new DogAnimal("Dog",13, 110, "Bulldog"));
        dogs.Add(new DogAnimal("Dog",13, 110, "German Shepherd"));
        dogs.Add(new DogAnimal("Dog",13, 110, "Rottweiler"));
        dogs.Add(new DogAnimal("Dog",13, 110, "Labrador Retriever"));
        //dogs.Add(new HorseAnimal("Horse",40,600,"Icelandic")); Answer: its doesn't support horse animal class because lists will be added only dog animal instance...

        foreach (DogAnimal dog in dogs)
        {
            Console.WriteLine ($"Name:{dog.breed}");
        }
    }

    
}