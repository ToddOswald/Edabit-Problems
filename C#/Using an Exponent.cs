        public static long CalculateExponent(long number, long exponent) 
        {
            double result = Math.Pow(number,exponent);

            long longResult = (long)result;
            
            return longResult;
        } 


// take a number and expoenent and get the result