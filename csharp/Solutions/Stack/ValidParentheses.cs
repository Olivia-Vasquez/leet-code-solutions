public class ValidParenthesesSolution {
    // Method to check if parentheses in a string are valid

    public bool IsValid(string s) {
        // Create stack to keep track of opening parentheses
        var stack = new Stack<char>();

        // Iterate through each character in the string
        foreach(var c in s){
            // If it's an opening parenthesis, push it onto the stack
            if(c == '(' || c == '{' || c == '['){
                stack.Push(c);
            }
            // If it's a closing parenthesis, check if it matches the top of the stack
            else if(c == ')' || c == '}' || c == ']'){
                if(stack.Count == 0) return false; // No matching opening parenthesis
                char top = stack.Pop();
                if((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '[')){
                    return false; // Mismatched parentheses
                }
            }
        }
        // If the stack is empty at the end, all parentheses are valid
        return stack.Count == 0;
    }
}