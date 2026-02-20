public class DecodeStringSolution {
    // Method to decode a string with the format k[encoded_string]

    public string DecodeString(string s) {
        // Create stack to keep track of previous strings and counts
        var stack = new Stack<(string, int)>();
        string currentString = "";
        int currentNum = 0;

        // Iterate through each character in the string
        foreach(var c in s){
            if(char.IsDigit(c)){
                currentNum = currentNum * 10 + (c - '0'); // Build the number for multi-digit counts
            }
            else if(c == '['){
                stack.Push((currentString, currentNum)); // Push current string and count onto stack
                currentString = ""; // Reset current string
                currentNum = 0; // Reset current number
            }
            else if(c == ']'){
                var (prevString, count) = stack.Pop(); // Pop the last string and count from stack
                currentString = prevString + String.Concat(Enumerable.Repeat(currentString, count)); // Repeat the current string and concatenate with previous string
            }
            else{
                currentString += c; // Append character to current string
            }
        }
        return currentString; // Return the fully decoded string
    }
}