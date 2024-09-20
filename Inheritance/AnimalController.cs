

public class AnimalController
{
    //case 1: Horse animal functionality
    public void showHorseAnimal()
    {
        //case 1: Horse animal
        HorseAnimal horseAnimal = new HorseAnimal("Horse", 10, 120, 40);
        Console.WriteLine($"{horseAnimal.Name} animal is {horseAnimal.Age} years old.\nIt has {horseAnimal.Weight}kg weight and its life span is {horseAnimal.lifeSpan}.");
        horseAnimal.DoSound();
    }

    //case 2: Dog animal functionality
    internal void showDogAnimal()
    { 
        DogAnimal dogAnimal = new DogAnimal("Dog",5, 30, true);
        Console.WriteLine($"{dogAnimal.Name} animal is {dogAnimal.Age} years old.\nIt has {dogAnimal.Weight}kg weight and it has a tail.");
        dogAnimal.DoSound();
    }

    // case 3: Hedgehog animal functionality
    internal void showHedgehogAnimal()
    {
        HedgehogAnimal hedgehogAnimal = new HedgehogAnimal("Hedgehog", 1, 2,3000);
        Console.WriteLine($"{hedgehogAnimal.Name} animal is {hedgehogAnimal.Age} years old.\nIt has {hedgehogAnimal.Weight}kg weight and it has a {hedgehogAnimal.noOfQuills} quills on its back.");
        hedgehogAnimal.DoSound();
    }

    // case 4: worm functionality
    internal void showWormAnimal()
    {
        WormAnimal wormAnimal = new WormAnimal("Worm",7, 0.25, false);
        Console.WriteLine($"{wormAnimal.Name} animal has {wormAnimal.Age} years of life span.\nIt has {wormAnimal.Weight}grams weight and {wormAnimal.checkHasEars(wormAnimal.hasEars)}.");
        wormAnimal.DoSound();
    }

    // case 5: bird functionality
    internal void showBirdAnimal()
    {
        BirdAnimal birdAnimal= new BirdAnimal("Bird",20, 150, 3.5);
        Console.WriteLine($"{birdAnimal.Name} animal has {birdAnimal.Age} years of life span.\nIt has a maximum {birdAnimal.Weight}kg weight and it has {birdAnimal.wingSpan} meters wingspan.");
        birdAnimal.DoSound();

        PelicanBird pelicanBird= new PelicanBird("Pelican Bird",20, 15, 3.5, 50);
        Console.WriteLine($"{pelicanBird.Name} has {pelicanBird.Age} years of life span.\nIt has a maximum {pelicanBird.Weight}kg weight, it has {pelicanBird.wingSpan} meters wingspan and it has {pelicanBird.beak}inches long beak pouch.");
        pelicanBird.DoSound();

        FlamingoBird flamingoBird = new FlamingoBird("Flamingo Bird",30, 3.5, 100, "Pink color");
        Console.WriteLine($"{flamingoBird.Name} has {flamingoBird.Age} years of life span.\nIt has a maximum {flamingoBird.Weight}kg weight, it has {flamingoBird.wingSpan} centimeters wingspan and it has {flamingoBird.color} with black feathers.");
        flamingoBird.DoSound();

        SwanBird swanBird = new SwanBird("Swan Bird",12, 12, 2.4, "herbivorous");
        Console.WriteLine($"{swanBird.Name} has {swanBird.Age} years of life span.\nIt has a maximum {swanBird.Weight}kg weight, it has {swanBird.wingSpan} centimeters wingspan and it is {swanBird.foodType} kind of bird.");
        swanBird.DoSound();

    }

    // case 5: Wolf animal functionality
    internal void showWolfAnimal()
    {
        WolfAnimal wolfAnimal = new WolfAnimal("Wolf", 16, 80, 40) ;
        Console.WriteLine($"{wolfAnimal.Name} animal has {wolfAnimal.Age} years of life span.\nIt has a maximum {wolfAnimal.Weight}kg weight and it runs {wolfAnimal.runningSpeed} miles per hour.");
        wolfAnimal.DoSound();

        WolfMan wolfMan = new WolfMan("Wolf", 12, 70, 35) ;
        Console.WriteLine($"{wolfMan.Name} animal has {wolfMan.Age} years of life span.\nIt has a maximum {wolfMan.Weight}kg weight and it runs {wolfMan.runningSpeed} miles per hour.");
        wolfMan.DoSound();
        wolfMan.Talk();
    }
}
