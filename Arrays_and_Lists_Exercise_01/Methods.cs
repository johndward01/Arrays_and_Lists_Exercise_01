namespace Arrays_and_Lists_Exercise_01;

public static class Methods
{
    // TODO: Create a method that takes an array of numbers and replaces all of the even numbers with 0
    // and display them to the console
    public static int[] ReplaceEvens(int[] numbers)
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
    // and display them to the console
    public static string[] RemoveExclamationMarks(string[] strs)
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

        //var newArray = new string[strs.Length];
        //var strWithoutExclamations = "";
        //for (int i = 0; i < strs.Length; i++)
        //{
        //    for (int j = 0; j < strs[i].Length; j++)
        //    {
        //        if (strs[i][j] == '!')
        //        {
        //            continue;
        //        }
        //        strWithoutExclamations += strs[i][j];
        //    }
        //    newArray[i] = strWithoutExclamations;
        //    strWithoutExclamations = "";
        //}
        //return newArray;
    }


    // TODO: Create a method that takes an array of Cats and sorts them by the Name's length (smallest first)
    // and display them to the console


    // TODO: Create a method that takes an array of Dogs and sorts them by Breed (oldest first)
    // and display them to the console


    // TODO: Create a method that takes an array of Animals and returns the sum of all the animals ages
    // and display them to the console


    // TODO: Create a method that takes a list of numbers and removes any that are multiples of 3
    // and display them to the console


    // TODO: Create a method that takes a list of bools and adds them together (true = 10, false = 0)
    // and display them to the console


    // TODO: Create a method that takes a list of Dogs and a list of Cats and returns a list of Animals
    // that only has Cats OR Dogs with Ages above 10
    // and display them to the console


    // TODO: Create a method that takes a list of IDbConnections and orders them by their ConnectionTimeout 
    // and display them to the console
}

class Animal
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
}
class Dog : Animal { }
class Cat : Animal { }
