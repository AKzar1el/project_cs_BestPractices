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
#endregion