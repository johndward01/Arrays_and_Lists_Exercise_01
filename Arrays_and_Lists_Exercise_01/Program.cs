using Arrays_and_Lists_Exercise_01;
using Arrays_and_Lists_Exercise_01.DBConnections;
using System.Data;

// Complete all of the TODO's here AND in the Methods class


// TODO: Call the method that takes an array of numbers and replaces all of the even numbers with 0
// and display them to the console
int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };



// TODO: Call the method that takes an array of strings and removes all of the !'s
// and display them to the console
string[] myStringArray = { "Zero", "On!e", "!Two", "Three!!", "!F!o!u!r!", "!!!!!Five", "Six", "!S!!e!!!v!!!!e!!!!!n!!!!!!", "Eight" };



// TODO: Call the method that takes an array of Animals and returns the sum of all the animals ages
// and display them to the console
#region Dogs and Cats (instantiated)
var cat1 = new Cat() { Age = 10 };
var cat2 = new Cat() { Age = 1 };
var cat3 = new Cat() { Age = 5 };
var cat4 = new Cat() { Age = 7 };
var cat5 = new Cat() { Age = 2 };
var dog1 = new Dog() { Age = 12 };
var dog2 = new Dog() { Age = 4 };
var dog3 = new Dog() { Age = 2 };
var dog4 = new Dog() { Age = 3 };
var dog5 = new Dog() { Age = 6 };
#endregion
var animals = new Animal[] { cat1, cat2, cat3, cat4, cat5, dog1, dog2, dog3, dog4, dog5 };


// TODO: Call the method that takes a list of numbers and removes any that are multiples of 3
// and display them to the console
var numbers = new List<int> { 45, 12, 67, 33, 88, 10, 23, 90, 51, 78 };


// TODO: Call the method that takes a list of bools and adds them together (true = 10, false = 0)
// and display them to the console
var boolList = new List<bool> { true, true, false, true, false, true, true, false, true, false, true, false, true, false, true, true };



// TODO: Call the method that takes a list of Dogs and a list of Cats and returns a list of Animals
// that only has Cats OR Dogs with Ages above 10
// and display them to the console
#region Dogs and Cats (instantiated)
var cat100 = new Cat() { Age = 10 };
var cat200 = new Cat() { Age = 11 };
var cat300 = new Cat() { Age = 5 };
var cat400 = new Cat() { Age = 7 };
var cat500 = new Cat() { Age = 2 };
var dog100 = new Dog() { Age = 12 };
var dog200 = new Dog() { Age = 14 };
var dog300 = new Dog() { Age = 12 };
var dog400 = new Dog() { Age = 3 };
var dog500 = new Dog() { Age = 16 };
#endregion
var dogs = new List<Dog>() { dog100, dog200, dog300, dog400, dog500 };
var cats = new List<Cat>() { cat100, cat200, cat300, cat400, cat500 };



// TODO: Call the method that takes a list of IDbConnections and orders them by their ConnectionTimeout (Longest to Shortest)
// and display them to the console
#region Connections (instantiated)
var mySql = new MySQLConnection();
var postgreSql = new PostgreSQLConnection();
var mongo = new MongoDBConnection();
var microsoftSql = new MSSQLConnection();
#endregion
var connections = new List<IDbConnection>() { postgreSql, mongo, microsoftSql, mySql };
