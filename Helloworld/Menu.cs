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
       Console.WriteLine( " Milk is 0.99 cents");
      } else if (selection == "5") {
       Console.WriteLine( " jucie is 0.99 cents");
      } 
    }
    }

}



