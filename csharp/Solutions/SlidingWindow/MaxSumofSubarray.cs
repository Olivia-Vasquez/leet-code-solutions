public class MaxSumofSubarraySolution {

    // Method to find the maximum sum of a subarray of size k
    public int MaxSumofSubarray(int[] nums, int k) {
        int maxSum = 0;
        int currentSum = 0;

        // Calculate the sum of the first window of size k
        for (int i = 0; i < k; i++) {
            currentSum += nums[i];
        }
        maxSum = currentSum;

        // Slide the window over the array and calculate the sum for each window
        for (int i = k; i < nums.Length; i++) {
            currentSum += nums[i] - nums[i - k]; // Add next element and remove the first element of the previous window
            maxSum = Math.Max(maxSum, currentSum); // Update max sum if current sum is greater
        }

        return maxSum;
    }
}