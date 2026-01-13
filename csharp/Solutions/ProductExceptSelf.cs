public class ProductExceptSelfSolution {

    // Method to return an array such that each element at index i is the product of all elements in the input array except nums[i]
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        Array.Fill(res, 1);

        for(int i=0; i<nums.Length; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                if(i!=j)
                {
                    res[i] = res[i]*nums[j];
                }
            }
        }


        return res;
    }
}
