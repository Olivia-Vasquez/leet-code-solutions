using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        int[] result = TwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return Array.Empty<int>();
    }
}
