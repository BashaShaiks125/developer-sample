using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n) 
        {
            if(n>0)
            {
                int fact= n;
                for (int i = n - 1; i >= 1; i--)
                    fact= fact*i;
                return fact;
            }
            else throw new ArgumentException("Please provide valid number for factorial");
        }

        public static string FormatSeparators(params string[] items)
        {
            if(items == null || items.Length==0)
                return string.Empty;
            if(items.Length= 1)
                return items[0];
            if(items.Length == 2)
                return $"{items[0]} and {items[1]}";

            var str= string.Join(", ", items, 0, items.Length-1);
            return $"{str} ,and {items[^1]}";
        };
    }
}
