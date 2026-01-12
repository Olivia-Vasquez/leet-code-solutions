public class ValidAnagramSolution {

    // Method to check if two strings are anagrams of each other
    public bool IsAnagram(string s, string t) {
    if(s.Length!=t.Length)
    {
        return false;
    }

    bool trigger = false;
    for(int i=0; i<s.Length; i++)
    {
        for(int j=0; j<t.Length; j++)
        {
            trigger = false;
            if(s[i]==t[j])
            {
                t = t.Remove(j, 1);
                trigger = true;
                break;
            }
        }
        if(trigger)
        {
            continue;
        }
        else
        {
            return false;
        }
    }
        return true;
    }
}
