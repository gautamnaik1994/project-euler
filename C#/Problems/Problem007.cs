/*
The sum of the squares of the first ten natural numbers is,
12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */
using System;
using System.Collections.Generic;
public class Problem007
{
    public static int Solution()
    {
        int difference = 0;
        int sumOfSquare = 0,squareOfSum=0;

        for (int i = 1; i < 101;i++){
            sumOfSquare += GetSquare(i);
            squareOfSum += i;
        }
        difference = GetSquare(squareOfSum) - sumOfSquare;

        return difference;
    }

    static int GetSquare(int n){
        return n * n;
    }
}
