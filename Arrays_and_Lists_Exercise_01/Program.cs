using Arrays_and_Lists_Exercise_01;
using Arrays_and_Lists_Exercise_01.DBConnections;
using System.Data;

// Complete all of the TODO's here AND in the Methods class


// TODO: Call the method that takes an array of numbers and removes all of the even numbers
int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


// TODO: Call the method that takes an array of strings and removes all of the !'s
string[] myStringArray = { "Zero", "On!e", "!Two", "Three!!", "!F!o!u!r!", "!!!!!Five", "Six", "!S!!e!!!v!!!!e!!!!!n!!!!!!", "!" };


// TODO: Call the method that takes an array of Cats and sorts them by the Name's length (smallest first)
string[] catNames = { "Fluffy", "Whiskers", "Mittens", "Shadow", "Simba", "Milo", "Tiger", "Smoky", "Socks", "TabbyTabs" };


// TODO: Call the method that takes an array of Dogs and sorts them by Breed (oldest first)
string[] dogNames = { "Max", "Bella", "Charlie", "Scrappy", "Scooby", "Rin Tin Tin", "Buddy", "Old Yeller", "Otis", "Bear" };


// TODO: Call the method that takes an array of Animals and returns the sum of all the animals ages
#region Dogs and Cat (instantiated)
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
List<int> numbers = new List<int> { 45, 12, 67, 33, 88, 10, 23, 90, 51, 78 };


// TODO: Call the method that takes a list of bools and adds them together (true = 10, false = 0)
List<bool> boolList = new List<bool> { true, false, true, true, false, true, false, false, true, true };


// TODO: Call the method that takes a list of Dogs and a list of Cats and returns a list of Animals
// that only has Cats OR Dogs with Ages above 10
#region Dogs and Cat (instantiated)
var cat10 = new Cat() { Age = 10 };
var cat20 = new Cat() { Age = 11 };
var cat30 = new Cat() { Age = 5 };
var cat40 = new Cat() { Age = 7 };
var cat50 = new Cat() { Age = 2 };
var dog10 = new Dog() { Age = 12 };
var dog20 = new Dog() { Age = 14 };
var dog30 = new Dog() { Age = 12 };
var dog40 = new Dog() { Age = 3 };
var dog50 = new Dog() { Age = 16 };
#endregion
var dogs = new List<Dog>() { dog10, dog20, dog30, dog40, dog50 };
var cats = new List<Cat>() { cat10, cat20, cat30, cat40, cat50 };


// TODO: Call the method that takes a list of IDbConnections and orders them by their ConnectionTimeout 
#region Connections (instantiated)
var mySql = new MySQLConnection();
var postgreSql = new PostgreSQLConnection();
var mongo = new MongoDBConnection();
var microsoftSql = new MSSQLConnection();
#endregion
var connections = new List<IDbConnection>() { mySql, postgreSql, mongo, microsoftSql };