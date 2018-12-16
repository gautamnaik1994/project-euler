using System;

public class Problem001
{
    public static int Solution()
    {
        int i = 0;
        int sum = 0;
        for (i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}