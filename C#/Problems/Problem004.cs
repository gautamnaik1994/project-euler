/*
 A palindromic number reads the same both ways. The largest palindrome made
  from the product of two 2-digit numbers is 9009 = 91 × 99.
 Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System;
using System.Collections.Generic;

public class Problem004
{
    public static int Solution()
    {
        int maxPalindrome = 0;
        HashSet<int> palindromes = new HashSet<int>();
        for (int i = 100; i < 1000; i++)
        {
            for (int j = 100; j < 1000; j++)
            {
                var prod = j * i;
                if (prod > 100000 && Utils.IsPalindrome(prod))
                    palindromes.Add(prod);
            }
        }
         foreach (int j in palindromes)
        {
            if (j > maxPalindrome)
                maxPalindrome = j;
        }
        return maxPalindrome;
    }
}
