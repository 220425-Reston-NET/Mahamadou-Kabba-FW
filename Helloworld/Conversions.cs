public class Conversions 
{

// Static keyword will make whatever class member belong to the class itself
//  For us it means we dont have to create object out of the classs t0 reference it
    public static void ConversionsMenu()
    {
     // General coding terms
    //  Implicit => means something is done automatically
    //  Explicity => means you have to write some syntax

    Console.WriteLine("==== Conversion Demo =======");
    int number = 10;
    double numberDecimal = 76.3;
    string word = "hello";

    // Implicit converstion 
    // The computer/ compilar will automatically convert one datatype to another
    Console.WriteLine("=Implicit=");
    // double datatype can set its value using int datatype 
    numberDecimal = number;
    Console.WriteLine(numberDecimal);

    // Explicit 
    // you have to write syntax to tell the compiler you want to converse anyway 
    Console.WriteLine("=Explicit=");
    numberDecimal = 76.3;
    //A cast is required 
    //syntax: (datatype) variableName;
    number = (int)numberDecimal; 
    Console.WriteLine(number); // this will give 76 => whole number

    // More Explicit Conversion
    string numberString = number.ToString();
    Console.WriteLine(numberString);

// converting  string into numerical value
string doubleString = "438.1239";
double double2 = Convert.ToDouble(doubleString);
Console.WriteLine(double2/2);

    }
}