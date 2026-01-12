public class GroupAnagramsSolution {
    // Method to group anagrams from a list of strings

    public List<List<string>> GroupAnagrams(string[] strs) {
        // Create empty dictionary where each key is count of each letter and each value is a list of anagrams
        var res = new Dictionary<string, List<string>>();

        // Get key for each word in strs
        foreach(var s in strs){
            char[] charArray = s.ToCharArray(); // Easier to sort
            Array.Sort(charArray);
            string sortedS = new string(charArray);
            if(!res.ContainsKey(sortedS))
            {
                res[sortedS] = new List<string>();
            }
            res[sortedS].Add(s);
        }
        //return sublists
        return res.Values.ToList<List<string>>();

    }
}

