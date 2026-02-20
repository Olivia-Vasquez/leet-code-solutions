public class NonOverlappingIntervalsSolution {
    // Method to find the minimum number of intervals to remove to make the rest of the intervals non-overlapping

    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals.Length == 0) return 0; // If there are no intervals, return 0

        // Sort the intervals by end time
        Array.Sort(intervals, (a, b) => a[1] - b[1]);

        int count = 1; // Count of non-overlapping intervals
        int end = intervals[0][1]; // End time of the last added interval

        // Iterate through the sorted intervals
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] >= end){ // If the start time of the current interval is greater than or equal to the end time of the last added interval, it does not overlap
                count++; // Increment count of non-overlapping intervals
                end = intervals[i][1]; // Update end time to the current interval's end time
            }
        }
        return intervals.Length - count; // The number of intervals to remove is total intervals minus non-overlapping intervals
    }
}