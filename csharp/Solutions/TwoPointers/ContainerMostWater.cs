public class ContainerMostWaterSolution {

    // Method to find the maximum area of water that can be contained
    public int MaxArea(int[] height) {
        int left = 0; // Pointer to the left end of the array
        int right = height.Length - 1; // Pointer to the right end of the array
        int maxArea = 0; // Variable to store the maximum area found

        while (left < right) {
            // Calculate the area formed by the lines at left and right pointers
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea); // Update max area if current area is greater

            // Move the pointer that points to the shorter line inward
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea; // Return the maximum area found
    }
}