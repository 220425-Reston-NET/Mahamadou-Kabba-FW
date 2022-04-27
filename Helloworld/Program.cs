// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

Console.WriteLine("Making a car object");
// [Class name] [NameofObject] = new [class name] ()
car carObj1 = new car();

// reference class members within object
int mile = carObj1.totalDistancePerFuel();
carObj1.Sum(5,10);
Console.WriteLine(mile);
string owner = "chadel1";
car carObj2 = new car(owner);
Console.WriteLine(carObj2.Owner);
carObj2.Owner = "Mustapha";
Console.WriteLine(carObj2.Owner);