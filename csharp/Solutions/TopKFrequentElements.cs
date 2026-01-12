public class TopKFrequentSolution {

    // Method to find the k most frequent elements in an array
    public int[] TopKFrequent(int[] nums, int k) {
        // Create dictionary where key is the int value being stored and value is the count of key in nums
        var dict = new Dictionary<int, int>();
        
        // Sort nums
        Array.Sort(nums);

        // Get key for each word in strs
        for(int i=0; i< nums.Length; i++)
        {

            if(!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = 0;
            }
            dict[nums[i]]++;
        }

        // keys with k largest values from dict
        var res = dict.OrderByDescending(item => item.Value)
                    .Take(k)
                    .Select(item => item.Key)
                    .ToArray();
        return res;

    }
}

