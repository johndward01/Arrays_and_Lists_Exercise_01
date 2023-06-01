using System.Data;

namespace Arrays_and_Lists_Exercise_01;

internal static class Methods
{
    // TODO: Create a method that takes an array of numbers and replaces all of the even numbers with 0
    internal static int[] ReplaceEvens(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                numbers[i] = 0;
            }
        }
        return numbers;
    }


    // TODO: Create a method that takes an array of strings and removes all of the !'s
    internal static string[] RemoveExclamationMarks(string[] strs)
    {
        var strWithoutExclamations = "";
        for (int i = 0; i < strs.Length; i++)
        {
            for (int j = 0; j < strs[i].Length; j++)
            {
                if (strs[i][j] == '!')
                {
                    continue;
                }
                strWithoutExclamations += strs[i][j];
            }
            strs[i] = strWithoutExclamations;
            strWithoutExclamations = "";
        }
        return strs;
    }


    // TODO: Create a method that takes an array of Animals and returns the sum of all the animals ages
    internal static int SumOfAnimalsAges(Animal[] animals)
    {
        var sum = 0;

        foreach (Animal animal in animals)
        {
            sum += animal.Age;
        }

        return sum;
    }


    // TODO: Create a method that takes a list of numbers and removes any that are multiples of 3
    internal static List<int> RemoveMultiplesOf3(List<int> numbers)
    {
        var list = new List<int>();
        foreach (var number in numbers)
        {
            if (number % 3 != 0)
            {
                list.Add(number);
            }
        }
        return list;
    }


    // TODO: Create a method that takes a list of bools and adds them together (true = 10, false = 0)
    internal static int SumBooleanList(List<bool> boolList)
    {
        var sum = 0;
        foreach (var item in boolList)
        {
            if (item)
            {
                sum += 10;
            }
        }
        return sum;
    }


    // TODO: Create a method that takes a list of Dogs and a list of Cats and returns a list of Animals
    // that only has Cats OR Dogs with Ages above 10
    internal static List<Animal> CreateAnimalList(List<Cat> cats, List<Dog> dogs)
    {
        var list = new List<Animal>();
        foreach (var cat in cats)
        {
            if (cat.Age > 10)
            {
                list.Add(cat);
            }
        }
        foreach (var dog in dogs)
        {
            if (dog.Age > 10)
            {
                list.Add(dog);
            }
        }
        return list;
    }


    // TODO: Create a method that takes a list of IDbConnections and orders them by their ConnectionTimeout (Longest to Shortest)
    internal static List<IDbConnection> SortConnectionsDescending(List<IDbConnection> connections)
    {
        var list = new List<IDbConnection>();
        foreach (var connection in connections)
        {

        }
    }
}

internal class Animal
{
    public int Age { get; set; }
}
internal class Dog : Animal { }
internal class Cat : Animal { }
