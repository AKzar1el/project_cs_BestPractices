using System.Collections;
using System.Text;

// Use parentheses to make clauses in an
// expression apparent, as shown in the following code.
int val1 = 0;
int val2 = 0;
int val3 = 0;
if ((val1 > val2) && (val1 > val3))
{
    // Take appropriate action.
}

#region String data type
// Declare empty string as the following example.
string? name = String.Empty;
Console.WriteLine("test");
Console.WriteLine(name);
Console.WriteLine(val1);
// Use string interpolation to concatenate
// short strings, as shown in the following code.
string displayName = $"{val1}, {val2}";

// To append strings in loops, especially when
// you're working with large amounts of text,
// use a StringBuilder object.
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 10000; i++)
{
    manyPhrases.Append(phrase);
}
//Console.WriteLine("tra" + manyPhrases);
#endregion

#region Implicitly typed local variables
// Use implicit typing when the type of the var
// is obvious from the right side of the assignment
var var1 = "This is clearly a string.";
var var2 = 27;

// Don't rely on the variable name to
// specify the type of the variable.
var inputInt = Console.ReadLine();
Console.WriteLine(inputInt);
// In this case it is a string.
#endregion

#region && and || operators
Console.Write("Enter a dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());

if ((divisor != 0) && (dividend / divisor > 0))
{
    Console.WriteLine("Quotient: {0}", dividend / divisor);
}
else
{
    Console.WriteLine("Attempted division by 0 ends up here.");
}
#endregion

#region Operator new
// Declarations
var instance1 = new ArrayList();
// or
ArrayList instance2 = new();
// are the same/equivalent to the following:
ArrayList instance3 = new ArrayList();

// Use object initializers to simplify object
// creation, as shown in the following example.
var instance4 = new ExampleClass
{
    Name = "Desktop",
    ID = 37414,
    Location = "Redmond",
    Age = 2.3
};
#endregion


