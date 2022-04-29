// Add more function to your Menu console app
// Create a new C# file inside your menu project called Data
// Create a Data class that will hold a collection of something for your menu
// Add any class members (methods, constructors, properties, fields, etc.) to Data class that you think will be useful to accomplish the following functions
// Add function to Menu to add elements to a collection
// This function might look different depending on what theme you created for your menu app
// Ex: If it is a shopping app then maybe a cart system would make the most sense
// Add function to Menu to display all the current elements to a collection
// Add function to Menu to remove certain elements to a collection
// Add function to Menu to search for a certain element in a collection
// Look into C# documentation of what methods are available for you in the collection that you are using that might help you find certain elements
// You can also just create your own coding logic to find certain elements in a collection
// If no element exist, be sure to tell the user that the element was not found.


public class Data 
{

// Dictionary<string, int>  _itemsArray = new Dictionary<string, int>();

// adding a list 
static List<string> _itemsArray = new List<string>();

public static void DataCollection()
    {
       // / List Lsit
     Console.WriteLine("=====Dictionary ====");
    _itemsArray.Add("soda");
    _itemsArray.Add("milk");
    _itemsArray.Add("bread");
    _itemsArray.Add("fruit");
    _itemsArray.Add("salad");

       Console.Clear();
        Console.WriteLine("===Data Demo===");
        bool repeat = true;
    while (repeat == true)
    {
        Console.WriteLine("What else may I do for you?");
        Console.WriteLine("press 1 to add item to cart");
        Console.WriteLine("press 2 to remove item");
        Console.WriteLine("press 3 to search for an item in cart");
        Console.WriteLine("press 0 to exit");

        // prompt user for import
        string selection  = Console.ReadLine();
        if (selection == "2")
        {
            // logic remvoe item ==> create one to add item
            Console.WriteLine("===Shopin Cart===");
            foreach (string item in _itemsArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("What item would you like to remove");

            string itemToRemove = Console.ReadLine();
            if (_itemsArray.Remove(itemToRemove))
            {
                Console.WriteLine("item removed");
            } else {
                Console.WriteLine("failed to remove: item not in Cart");
            }
        }
        if (selection == "3")
        {
            // logic to search item in cart 
            Console.WriteLine("What itme would you like to search in cart?");

            string itemToSearch = Console.ReadLine();
            bool matchSelection = false;
            foreach (string item in _itemsArray)
            {
                if (itemToSearch == item)
                {
                    matchSelection = true;
                }
            }
            if (matchSelection)
            {
                Console.WriteLine("item found");
            } else
            {
                Console.WriteLine("item not found");
            }
        }
        if (selection == "0")
        {
            repeat = false;
        } else
        {
            // if choose outside of available options 
           Console.WriteLine("please enter a valid input");
        }
    }
    
 }
}

