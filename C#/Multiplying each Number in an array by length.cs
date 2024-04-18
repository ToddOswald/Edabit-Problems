public static int[] MultiplyByLength(int[] arr)
{
    int length = arr.Length;
    int[] result = new int[length ];

    foreach (int x in arr)
    
    {
        result[x] = arr[x] * length;
        
    }
    
    return result;
    

}

/*

Find out how many values are in the array by using .Length

iterate through the numbers in the array uisng a foreach loop

multiply each number by the length of the array

return the result




Create a function to multiply all of the values in an array by the amount of values in the given array.
*/