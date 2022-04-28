using System.Collections;

public class collection
{
    // Array 
//    Used to store datatype and are fixed sizes 
//  syntax: detatype []  (name of variable ) = new datatype [size of array]
int[] _numberArray = new int[5] ;

// no fix seize ? use generic collection 
// they are collection that stores a specific datatypes
// they change size dynmaically 

// list collection
//  zero based index like array 
List<int> _numbersList = new List<int>();

// HashSet collection 
// there's no particular oder=> not zero index => cant get a speicfi ele
// you csnnot dublicat => everthing is unique
HashSet<int> _numbersHash = new HashSet<int>();

//  Dictionaty collections 
// Store information through key-value pairs
// there's no particular oder
// keys need to be unique
// you can specify datatype you want both the key and value to be
Dictionary<string, int>  _personAge = new Dictionary<string, int>();

// Non-generic collection
// they are collection that doesnt need any datatype
// it's called ArrayList collection
ArrayList _numbersArrayList = new ArrayList();
// MethodAccessException goes here 
public void collectionMain()
{
    Console.WriteLine("===Array Demo ====");
    // Allows us to set what to store in cetain position
    _numberArray[0] = 3;
    _numberArray[1] = 10;
    _numberArray[2] = 100;

    //  A way to go through an Array
    //  Console.WriteLine(0);

    foreach (int element in _numberArray)
    {
        Console.WriteLine(element);

    }

    foreach (int element in _numbersList)
    {
        Console.WriteLine(element);
    }
//   for loop 
//  sets variable; some condition to check if it repeats again: increment/decrement of a variable
for (int i = 0; i < _numbersList.Count; i++)
{
    Console.WriteLine(_numbersList[i]);
}

int i2 = 0;
while (i2 < _numbersList.Count)
{
    Console.WriteLine(_numbersList[i2]);
}
Console.WriteLine("===HashSet ===");
// put Haset loop here

// Dictionary 
Console.WriteLine("=====Dictionary ====");
_personAge.Add("chadel", 26);
_personAge.Add("Troy", 31);
_personAge.Add("Maaz", 24);

Console.WriteLine(_personAge["Maaz"]);
//  ArrayList use to list all diferent datatype
Console.WriteLine("===ArrayList Demo====");
_numbersArrayList.Add("Helloolloloo");
_numbersArrayList.Add(10);
_numbersArrayList.Add(true);

foreach (var item in _numbersArrayList)
{
    Console.WriteLine(item);
}

}
}