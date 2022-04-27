public class store 
{
    public void shop()
    {
    bool repeat= true;
    int  totalItem = 0;
    string selection = "";
    Console.WriteLine("Welcome to our grocery store");
    while (repeat)
    {
    //   Console.WriteLine("Welcome to our grocery store!");
    //  string answer = Console.ReadLine();
      Console.WriteLine("");
      Console.WriteLine("1 for beef");
      Console.WriteLine("2 for chicken");
      Console.WriteLine("3 for milk");
      Console.WriteLine("4 for eggs");
      Console.WriteLine("5 for jucie");
      Console.WriteLine("type done to checkout"); 
      selection = Console.ReadLine();
      if(selection == "done") {
          repeat = false;
      } else if (selection == "1") {
       Console.WriteLine( " beef is 50.56 dollars");
      } else if (selection == "2") {
       Console.WriteLine( "chicken is 66.66 dollars");
      } else if (selection == "3") {
       Console.WriteLine( " Eggs are 4.99 dollars");
      } else if (selection == "4") {
       Console.WriteLine( " jucie is 0.99 cents");
      } 
    }
    }

}

// public void totalItems()
//     {
//         Console.WriteLine(_Beef + " beef is 50.56 dollars");
//         Console.WriteLine(_Chicken + "chicken is 66.66 dollars");
//         Console.WriteLine(_Eggs + " Eggs are 4.99 dollars");
//         Console.WriteLine(_Juice + " jucie is 0.99 cents");


//     //   return keyword  is what a method will return/give back
//     // return _Beef;
//     }

    // this is constructor
// it is special method that will run whenever you create an object

// public string storeItem 
// {
    
//         // if(value <= 100 && value >= 0)
//         // {
//         //  _fuel = value;
//         // }  else {
//         //     Console.WriteLine("you can only put 0-100 in fuel");
//         //     // throw new Exception("Fuel can only be positive numbers");
//         // }
       
        
//     }


// while (repeat)
// {
//      console.WriteLine("Welcome to our grocery store!");
//      string answer = Console.ReadLine();
//      console.WriteLine("");
//      console.WriteLine("1 for beef");
//      console.WriteLine("2 for chicken");
//      console.WriteLine("3 for milk");
//      console.WriteLine("4 for eggs");
//      console.WriteLine("5 for jucie");
//      console.WriteLine("type done to checkout");

//      if (answer == "done")
//      {
//          repeat = false;
//      } else if (answer == _Beef) {
//         Console.WriteLine("beef 3.99 dollars ") ;
//      } else if (answer == 2){
//          Console.WriteLine("chicken 4.99 dollars");
//      } else if (answer == 3){
//      Console.WriteLine("milk 5.99 dollar");
 
//      } else if (answer == 4){
//      Console.WriteLine("eggs 6.99 dollars");
 
//      } else if (answer == 5){
//      Console.WriteLine("juice 7.99 dollars");
 
//      } else {
//          Console.WriteLine("type a valid input");
//         string answer = Console.ReadLine();

//      }
    


// }


