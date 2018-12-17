using System;
using System.Collections.Generic;

public class Problem003
{
    public static int Solution()
    {
        HashSet<long> primeNum = new HashSet<long>();
        long n = 600851475143;
        long maxPrime = 0;
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                primeNum.Add(i);
                n /= i;
            }
        }
        if (n > 2)
            primeNum.Add(n);

        foreach (int j in primeNum)
        {
            if (j > maxPrime)
                maxPrime = j;
        }
        return (int)maxPrime;
    }
}
