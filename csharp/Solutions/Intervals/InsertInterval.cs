public class InsertIntervalSolution {
    // Method to insert a new interval into a list of non-overlapping intervals and merge if necessary

    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var res = new List<int[]>();
        int i = 0;

        // Add all intervals that come before the new interval
        while(i < intervals.Length && intervals[i][1] < newInterval[0]){
            res.Add(intervals[i]);
            i++;
        }

        // Merge overlapping intervals with the new interval
        while(i < intervals.Length && intervals[i][0] <= newInterval[1]){
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        res.Add(newInterval); // Add the merged interval

        // Add all remaining intervals that come after the new interval
        while(i < intervals.Length){
            res.Add(intervals[i]);
            i++;
        }
        return res.ToArray(); // Convert list to array and return
    }
}