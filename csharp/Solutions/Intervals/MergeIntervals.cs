public class MergeIntervalsSolution {
    // Method to merge overlapping intervals in a list of intervals

    public int[][] Merge(int[][] intervals) {
        if(intervals.Length == 0) return new int[0][];
        
        // Sort the intervals by start time
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        var res = new List<int[]>();
        int[] currentInterval = intervals[0]; // Start with the first interval

        // Iterate through the sorted intervals
        foreach(var interval in intervals){
            // If the current interval overlaps with the next interval, merge them
            if(currentInterval[1] >= interval[0]){
                currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
            }
            else{
                res.Add(currentInterval); // Add the merged interval to the result list
                currentInterval = interval; // Move to the next interval
            }
        }
        res.Add(currentInterval); // Add the last interval
        return res.ToArray(); // Convert list to array and return
    }
}