public class EncodeDecodeSolution {

    // Method to encode a list of strings to a single string and decode it back
    public string Encode(IList<string> strs) {
        if(strs.Count==0)
        {
            return "-1";
        }
        string delimiter = "%%%?%";
        string res = "";


        res = string.Join(delimiter, strs);
        return res;
    }
    // Decodes a single string to a list of strings
    public List<string> Decode(string s) {
        if(s == "-1")
        {
            return new List<string>();
        }
        string delimiter = "%%%?%";

        List<string> strs = s.Split(delimiter).ToList();

        return strs;
   }
}
