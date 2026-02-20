public class MaxSumofDistinctSubarraySolution {

    // Method to find the maximum sum of a subarray with distinct elements
    public int MaxSumofDistinctSubarray(int[] nums) {
        int maxSum = 0;
        int currentSum = 0;
        var seen = new HashSet<int>();
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            // If the current element is already in the set, remove elements from the left until it's removed
            while (seen.Contains(nums[right])) {
                seen.Remove(nums[left]);
                currentSum -= nums[left];
                left++;
            }

            // Add the current element to the set and update the current sum
            seen.Add(nums[right]);
            currentSum += nums[right];
            maxSum = Math.Max(maxSum, currentSum); // Update max sum if current sum is greater
        }

        return maxSum;
    }
}