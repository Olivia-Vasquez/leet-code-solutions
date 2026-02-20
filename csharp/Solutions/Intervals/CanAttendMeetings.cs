public class CanAttendMeetingsSolution {
    // Method to determine if a person can attend all meetings given an array of meeting time intervals

    public bool CanAttendMeetings(int[][] intervals) {
        // Sort the intervals by start time
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        // Check for overlapping intervals
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] < intervals[i - 1][1]){ // If the start time of the current interval is less than the end time of the previous interval, there is an overlap
                return false;
            }
        }
        return true; // If no overlaps are found, return true
    }
}