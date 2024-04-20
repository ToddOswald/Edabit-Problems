using System.Linq;

public static int[] SortNumsAscending(int[] arr)
{
    int[] result = new int[arr.Length];
    int[] empty = new int[0];
    

    if (arr == null || arr.Length == 0)
    {
        return empty;
    }

    result = arr.OrderBy(x => x).ToArray();

    return result;
    
    
}