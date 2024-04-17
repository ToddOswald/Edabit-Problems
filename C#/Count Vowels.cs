using System.Linq;
public class Program 
{
        public static int CountVowels(string str) 
        {
            char[] vowels = {'a','e','i','o','u'};
            int totalCount = 0;

            foreach (char vowel in vowels)
            {
                int count = str.Count(c => char.ToLower(c) == vowel);
                totalCount += count;
            }

            return totalCount;
        }
}