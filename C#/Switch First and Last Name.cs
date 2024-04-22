    public static string NameShuffle(string str)
{
    string[] names = str.Split(' ');

    string firstName = names[0];
    string lastName = names[1];

    string lastFirstName = lastName +  ' ' + firstName;

    return lastFirstName;
}

/*
using string[] names = str.Split(" "); to separate

set string firstName to = names[0]
and string lastName to =names[1]
this will return the first and last name ans values not an array
use string fullname = lastName + " " + firstName 
return fullname;


Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
*/