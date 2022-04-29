// See https://aka.ms/new-console-template for more information
//  clear terminal 
Console.Clear();
//Menu Demo
// declearing object 
Menu MenuObject = new Menu();

bool repeat=true;
Console.WriteLine("Hello, welcome to my store! What is your name?");
// console.Readline() prompt user input to get user name;
MenuObject.Name = Console.ReadLine();
while(repeat==true){ 
    // invoking greetUserMethod (function)
    MenuObject.GreetUserMethod(); 
//    declesring answer varibale type-string => console.Readline() prompt user input
    string answer = Console.ReadLine();

    if (answer == "1")
    {
         MenuObject.BuyItemMethod();
    }
    else if (answer == "2")
    {
         Console.WriteLine("Your total price is " + MenuObject.TotalPrice + " Thanks for coming");
        repeat = false;
    }

    
}
// Console.WriteLine("Hello, World!");

// // Console.WriteLine("Making a car object");
// // [Class name] [NameofObject] = new [class name] ()
// car carObj1 = new car();

// // reference class members within object
// int mile = carObj1.totalDistancePerFuel();
// carObj1.Sum(5,10);
// // Console.WriteLine(mile);
// string owner = "chadel1";
// car carObj2 = new car(owner);
// // Console.WriteLine(carObj2.Owner);
// carObj2.Owner = "Mustapha";
// // Console.WriteLine(carObj2.Owner);

// carObj2.fuel = 80;
// Console.WriteLine(carObj2.fuel);

// menu stuff  
// store storeObject1 = new store();
// Console.WriteLine(storeObject1);

// Menu groceryMenu = new Menu();

// groceryMenu.CustomersOrder();

// ==============
// collection collectObj = new collection();
// collectObj.collectionMain();

// // ========
// // invoking static stuff 
// Conversions.ConversionsMenu();
// Data.shoppingBag();
// ========== Data file stuff ======= 
Data.DataCollection();
// Data DataMenu = new Data();
// DataMenu.DataCollection();
// DataMenu.shoppingBag();