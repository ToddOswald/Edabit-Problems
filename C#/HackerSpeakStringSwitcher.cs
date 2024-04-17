public static string HackerSpeak(string str)
{
    string result = "";

    for (int i = 0; i < str.Length; i++)
    {
        char letter = str[i];

        switch(letter)
        {
            case 'a':
                result = result + '4'; 
                break;
            case 'e':
                result = result + '3';
                break;
            case 'i':
                result = result + '1';
                break;
            case 'o':
                result = result + '0';
                break;
            case 's':
                result = result + '5';
                break;
            default:
            
                result = result + letter;
                break;
        }
    }   

    return result;
}


/*

need to have a string that is different than the orriginal string

need an array that holds the letters that we need to change

need something that changes out the letters to what we want e.g. a = 4

return the new string

get out the regular letters 




Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.

In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.
*/