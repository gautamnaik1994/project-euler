/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible(divisible with no remainders) by all of the numbers from 1 to 20?
 */
using System;
using System.Collections.Generic;
public class Problem005
{
    public static int Solution()
    {
        int minNumber = 0;
        bool flag = false;
        int number = 22;
        while (!flag)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (!(number % i == 0))
                {
                    flag = false;
                    i = 21;
                }
                else{
                    flag = true;
                    minNumber = number;
                }
              
            }
            number += 2;
        }
        return minNumber;
    }
}
