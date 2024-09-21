


public class AnimalController
{
    //case 1: Horse animal functionality
    public void showHorseAnimal()
    {
        //case 1: Horse animal
        HorseAnimal horseAnimal = new HorseAnimal("Horse", 30, 600, "Icelandic horse");
        Console.WriteLine($"Name:{horseAnimal.Name}, Life span:{horseAnimal.Age}, Maximum Weigth:{horseAnimal.Weight}kg, Breed:{horseAnimal.breed}");
        horseAnimal.DoSound();
    }

    //case 2: Dog animal functionality
    internal void showDogAnimal()
    { 
        DogAnimal dogAnimal = new DogAnimal("Dog",13, 110, "Bulldog");
        Console.WriteLine($"Name:{dogAnimal.Name}, Life span:{dogAnimal.Age}, Maximum Weight:{dogAnimal.Weight}kg, Breed: {dogAnimal.breed}");
        dogAnimal.DoSound();
    }

    // case 3: Hedgehog animal functionality
    internal void showHedgehogAnimal()
    {
        HedgehogAnimal hedgehogAnimal = new HedgehogAnimal("Hedgehog", 1, 2,3000);
        Console.WriteLine($"Name:{hedgehogAnimal.Name}, Life span:{hedgehogAnimal.Age}, Maximum Weight:{hedgehogAnimal.Weight}kg, No.of.quills:{hedgehogAnimal.noOfQuills}");
        hedgehogAnimal.DoSound();
    }

    // case 4: worm functionality
    internal void showWormAnimal()
    {
        WormAnimal wormAnimal = new WormAnimal("Worm",7, 0.25, false);
        Console.WriteLine($"Name:{wormAnimal.Name}, Life span:{wormAnimal.Age}, Maximum Weight:{wormAnimal.Weight}grams, Ears:{wormAnimal.checkHasEars(wormAnimal.hasEars)}");
        wormAnimal.DoSound();
    }

    // case 5: bird functionality
    internal void showBirdAnimal()
    {
        BirdAnimal birdAnimal= new BirdAnimal("Bird",20, 150, 3.5);
        Console.WriteLine($"Name:{birdAnimal.Name}, Life span:{birdAnimal.Age}, Maximum Weight:{birdAnimal.Weight}kg, Wingspan:{birdAnimal.wingSpan} meters");
        birdAnimal.DoSound();

        PelicanBird pelicanBird= new PelicanBird("Pelican Bird",20, 15, 3.5, 50);
        Console.WriteLine($"Name:{pelicanBird.Name}, Life span:{pelicanBird.Age}, Maximum Weight:{pelicanBird.Weight}kg, Wingspan:{pelicanBird.wingSpan} meters, beak:{pelicanBird.beak}inches");
        pelicanBird.DoSound();

        FlamingoBird flamingoBird = new FlamingoBird("Flamingo Bird",30, 3.5, 100, "Pink color");
        Console.WriteLine($"Name:{flamingoBird.Name}, Life span:{flamingoBird.Age}, Maximum Weight:{flamingoBird.Weight}kg, Wingspan:{flamingoBird.wingSpan} cm , Color:{flamingoBird.color}");
        flamingoBird.DoSound();

        SwanBird swanBird = new SwanBird("Swan Bird",12, 12, 2.4, "herbivorous");
        Console.WriteLine($"Name:{swanBird.Name}, Life span:{swanBird.Age}, Maximum Weight:{swanBird.Weight}kg, Wingspan:{swanBird.wingSpan} cm, Food type:{swanBird.foodType}");
        swanBird.DoSound();

    }

    // case 5: Wolf animal functionality
    internal void showWolfAnimal()
    {
        WolfAnimal wolfAnimal = new WolfAnimal("Wolf", 16, 80, 40) ;
        Console.WriteLine($"Name:{wolfAnimal.Name}, Life span:{wolfAnimal.Age}, Maximum Weight:{wolfAnimal.Weight}kg, Run speed:{wolfAnimal.runningSpeed} miles per hour.");
        wolfAnimal.DoSound();

        WolfMan wolfMan = new WolfMan("Wolf Man", 12, 70, 35, "Yes") ;
        wolfMan.DoSound();
        wolfMan.Talk();
    }

    internal void showCatAnimal()
    {
        CatAnimal catAnimal= new CatAnimal("Cat",18, 4.5, true);
        catAnimal.DoSound();
        catAnimal.Stats();
    }
}
