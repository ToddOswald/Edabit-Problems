using System;
using System.Linq;


public static int GetAbsSum(int[] arr) 
{
    int[] result = new int[arr.Length];

    for (int i = 0; i <arr.Length; i++)
    {
        result[i] = Math.Abs(arr[i]);
    }

    return result.Sum();
}