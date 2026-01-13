public class ThreeSumSolution {
    // Method to find all unique triplets in the array which gives the sum of zero
    public List<List<int>> ThreeSum(int[] nums) {
        // Initialize return array
        List<List<int>> ans = new List<List<int>>();

        // Sort input array
        Array.Sort(nums);

        // Two pointer attempt
        for(int i=0; i<nums.Count() - 2; i++)
        {
            // Skips duuplicate sums
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            int j = i+1;
            int k = nums.Count()-1;

            // Find pair j,k such that nums[j]+nums[k] = - nums[i]
            while(j < k)
            {
                // If sum too small, increase j
                if (nums[j]+nums[k] < -nums[i])
                {
                    j++;
                } else if (nums[j]+nums[k] > -nums[i])
                {
                    k--;
                } else
                {
                    List<int> list = new List<int> { nums[i], nums[j], nums[k] };
                    ans.Add(list);
                    while (j < k && nums[j] == nums[j + 1]) j++;
                    while (j < k && nums[k] == nums[k - 1]) k--;
                    j++;
                    k--;
                }
            }
        }

        return ans;
    }
}