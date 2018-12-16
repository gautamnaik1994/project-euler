using System;

public class Problem002
{
    public static int Solution()
    {
        const int LIMIT = 4000000;
        int fnum = 1; int snum = 1;
        int sum = 0;
        while (fnum < LIMIT)
        {
            if (fnum % 2 == 0)
                sum += fnum;
            int temp = snum;
            snum += fnum;
            fnum = temp;
        }
        return sum;
    }
}
