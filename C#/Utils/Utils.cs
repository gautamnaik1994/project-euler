using System;

public class Utils
{
    public static bool IsPalindrome(int number)
    {
        string s = number.ToString();
        char[] charArray = s.ToCharArray();
        char[] reverseArray = s.ToCharArray();
        Array.Reverse(reverseArray);
        return charArray.Equals(reverseArray);
         
    }
    public static bool IsPalindrome(string s)
    {

        return true;
    }
}