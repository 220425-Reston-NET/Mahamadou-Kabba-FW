// Th is how you create a class by using the class keyword 
// public is just there to make 
public class car 
{
    // this is feild 
    // it is a method that will
    // by  defualt, feild should be private ? 
    private string _color ;
    private string _owner ;
    private int _fuel;
    private int _gallonPerMile;

    // this is a method
    //  they are a way to represent behavior/function and it will run multiple lines of code
    // void means method wont return anything 
    //  any other detatype method will expect to retunr that datatype
    public int totalDistancePerFuel()
    {
        Console.WriteLine("current fuel: " + _fuel);
        Console.WriteLine("Gallon Per mile: " + _gallonPerMile);
        Console.WriteLine($"Gallon Per mile:  {_gallonPerMile} This is the owner: {_owner}");

      Console.WriteLine(_fuel/_gallonPerMile + " this how many miles");

    //   return keyword  is what a method will return/give back
    return _fuel/_gallonPerMile;
    }

    //  Methods can also have parameter
    // Parameters are implemented by adding in datatype inside a parameter
     public void Sum(int num1,int num2)
    {
     Console.WriteLine(num1+num2);
    }
// this is constructor
// it is special method that will run whenever you create an object
public car()
{
    _color = "Blue";
     _fuel = 100;
     _gallonPerMile  = 5;
     _owner = "Mahamadou";
    
}
public car(string p_owner) 
{
_owner = p_owner;
}

//  this is property 
// GIVES us the flexibilty to check that data being stored in correct, let only certain things access data, make things read or write
public string Owner 
{
    // proetry  must use get/set key word
    // the keyword is the way 
    get { return _owner + " is the owner of this bad boy";}

    //  set key word is how you set the the data that's being stored
    // set key word allows you to mess with readonly stuff
    set{_owner = value;}
}

// fuel can only hold 0-100 use if
public int fuel 
{
    get {return _fuel;}
    set
    {
        if(value <= 100 && value >= 0)
        {
         _fuel = value;
        }  else {
            Console.WriteLine("you can only put 0-100 in fuel");
            // throw new Exception("Fuel can only be positive numbers");
        }
       
        
    }
}
}

    // this is a constructor 
    // It is a method that will execute whenever you create an object 
//     public car () {
//         Console.WriteLine("");
//     }
//     public car(string p_color)
//     {
//         Console.WriteLine("Making a car object");
//         _color = p_color;
//     }
 