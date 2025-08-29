using System;
using Solutions;  // allow referencing my solutions
public class Solution 
{
    public int MySqrt(int x) 
    {
        int result = 0;
        int left = 0;
        int right = x;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            long sq = (long)mid * mid;

            if (sq == x) return mid;
            if (sq < x)
            {
                result = mid;        
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;

    }

}