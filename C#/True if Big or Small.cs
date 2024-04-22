public static bool SameCase(string str)
{

if (str.All(char.IsUpper))
{
    return true;
}
else if (str.All(char.IsLower))
{
return true;
}
else 
{
    return false;
}
}

/*

go through string

if statement to return true if all lower or all upper

else statement to return false if mexture of the two 





Create a function that returns true if an input string contains only uppercase or only lowercase letters.
*/