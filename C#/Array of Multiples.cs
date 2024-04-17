public static int[] ArrayOfMultiples(int num, int length) 
{

    int[] answer = new int[length]; 

    for(int i = 0; i < length; i++ )
    {
            answer[i] = num * (i + 1);
    }

    return answer;
    
    
}