namespace Arrays_and_Lists_Exercise_01;

internal static class Methods
{
    // TODO: Create a method that takes an array of numbers and removes all of the even numbers
    public static int[] RemoveEvens(int[] numbers)
    {
        throw new NotImplementedException();
    }

    // TODO: Create a method that takes an array of strings and removes all of the !'s


    // TODO: Create a method that takes an array of Cats and sorts them by the Name's length (smallest first)


    // TODO: Create a method that takes an array of Dogs and sorts them by Breed (oldest first)


    // TODO: Create a method that takes an array of Animals and returns the sum of all the animals ages


    // TODO: Create a method that takes a list of numbers and removes any that are multiples of 3


    // TODO: Create a method that takes a list of bools and adds them together (true = 10, false = 0)


    // TODO: Create a method that takes a list of Dogs and a list of Cats and returns a list of Animals
    // that only has Cats OR Dogs with Ages above 10


    // TODO: Create a method that takes a list of IDbConnections and orders them by their ConnectionTimeout 

}

class Animal
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
}
class Dog : Animal { }
class Cat : Animal { }
