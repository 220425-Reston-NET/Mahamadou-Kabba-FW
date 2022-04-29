// Create a different C# file named Menu.cs in HelloWorld
// Create a Menu class and put in all the class members (such as field, property, methods, etc.)
// you think you'll need to re-create your shell menu
// Note: Program.cs is the starting point of your program
// Push all the changes to your remote github repo. Note: 
//Look into Console.ReadLine() as it is similar to read command in shell

public class Menu{

//Property => allows us to change value of private field   
   //public int _cost=0;
    private string _name;
    public string Name
    {
        get{ return _name;}
        set{ _name = value;}
    } 
    public int _soda;
    public int _bread;
    public int _milk;
    public int _salad;
    public int _fruit;

    private int _totalPrice; //Saving the total price of what the user saved.
    public int TotalPrice
    {
        get{ return _totalPrice;}
        set{ _totalPrice = value;}
    }
    
     public Menu()
    {
        _name = " Kabba ";
        _soda = 10;
        _bread = 99;
        _milk = 10;
        _salad = 20;
        _fruit = 23;
    }

    //Method for greeting customer
    public void GreetUserMethod()
    {
        Console.Clear();
        Console.WriteLine("Hello " + _name + "! What can I do for you?");
        Console.WriteLine("1. Buy an item");
        Console.WriteLine("2. Checkout");
    }
    //    Method for buying something
     public void BuyItemMethod()
    {
        Console.WriteLine("1 - soda $" + _soda);
        Console.WriteLine("2 - bread $" + _bread);
        Console.WriteLine("3 - milk $" + _milk);
        Console.WriteLine("4 - salad $" + _salad);
        Console.WriteLine("5 - fruit $" + _fruit);

        string answer = Console.ReadLine();
        switch (answer)
        {
            case "1":
                _totalPrice += _soda;
                break;
            case "2":
                _totalPrice += _bread;
                break;
            case "3":
                _totalPrice += _milk;
                break;
            case "4":
                _totalPrice += _salad;
                break;
            case "5":
                _totalPrice += _fruit;
                break;
        }
        Console.WriteLine("Your current total is: " + _totalPrice);


    }
    
    

            
}

    







