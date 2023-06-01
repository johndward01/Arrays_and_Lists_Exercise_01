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


    // TODO: Create a method that takes an array of Cats and sorts them by the Name's length (smallest first)
    internal static Cat[] CatNamesAscending(Cat[] cats)
    {
        throw new NotImplementedException();

        //var newCats = new Cat[cats.Length];
        //for (int i = 0; i < cats.Length; i++)
        //{
        //    for (int j = 1; j < cats.Length; j++)
        //    {
        //        var smallestCat = cats[i];
        //        if (cats[j].Name.Length < cats[i].Name.Length)
        //        {
        //            cats[i] = cats[j];
                    
        //        }
        //    }
        //}        
        //return cats;
    }


    // TODO: Create a method that takes an array of Dogs and sorts them by Breed (oldest first)


    // TODO: Create a method that takes an array of Animals and returns the sum of all the animals ages


    // TODO: Create a method that takes a list of numbers and removes any that are multiples of 3


    // TODO: Create a method that takes a list of bools and adds them together (true = 10, false = 0)


    // TODO: Create a method that takes a list of Dogs and a list of Cats and returns a list of Animals
    // that only has Cats OR Dogs with Ages above 10


    // TODO: Create a method that takes a list of IDbConnections and orders them by their ConnectionTimeout 
}

internal class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
}
internal class Dog : Animal { }
internal class Cat : Animal { }
