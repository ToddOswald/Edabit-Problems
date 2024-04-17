public static double[] FindMinMax(double[] values) 
{
    double max;
    double min;

    
    

    max = values.Max();
    min = values.Min();

    List<double> numbers = new List<double> {min,max};
    double[] result = numbers.ToArray();

    return result;
}