public class MaxAreaSolution {
    // Method to find the maximum area of water that can be contained in O(n^2) time
    public int MaxArea(int[] heights) {
        int maxArea = 0;

        for (int i=0; i<heights.Count(); i++)
        {
            for(int j=i+1; j<heights.Count(); j++)
            {
                int newArea = Math.Min(heights[i],heights[j]) * (j-i);

                if(newArea>maxArea)
                {
                    maxArea=newArea;
                }
            }
        }

        return maxArea;
    }

    // Method to find the maximum area of water that can be contained in O(n) time
    public int MaxAreaOptimized(int[] heights) {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while(left < right)
        {
            int newArea = Math.Min(heights[left], heights[right]) * (right - left);
            if(newArea > maxArea)
            {
                maxArea = newArea;
            }
            if(heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}