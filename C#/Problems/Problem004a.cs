/*
 A palindromic number reads the same both ways. The largest palindrome made
  from the product of two 2-digit numbers is 9009 = 91 × 99.
 Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System;
using System.Collections.Generic;
public class Problem004a
{
    public static int Solution()
    {
        int maxPalindrome = 0;
        HashSet<int> palindromes = new HashSet<int>();
        for (int i = 999; i > 100; i--)
        {
            for (int j = 999; j > 100; j--)
            {
                var prod = j * i;
                if ( prod>maxPalindrome && Utils.IsPalindrome(prod) ){
                    maxPalindrome = prod;
                }
            }
        }
        return maxPalindrome;
    }
}
