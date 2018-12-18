using System;


    public class Utils
    {
        public static bool IsPalindrome(int n)
        {
            var originalInteger = n;
            var reversedInteger = 0;
            var remainder = 0;
            while (n != 0)
            {
                remainder = n % 10;
                reversedInteger = reversedInteger * 10 + remainder;
                n /= 10;
            }

            if (originalInteger == reversedInteger)
                return true;
            else
                return false;

        }

    }



