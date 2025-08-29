using System;
using System.Text; // Needed for StringBuilder

public class Solution {
    // Method to check if a string is a palindrome, ignoring non-alphanumeric characters and case
    public bool IsPalindrome(string s) {
        
        // StringBuilder is efficient for building strings in a loop
        StringBuilder sb = new StringBuilder();

        // Iterate through each character in the input string
        foreach (char c in s) {
            // Only keep letters and digits, ignore spaces and special characters
            if (char.IsLetterOrDigit(c)) {
                sb.Append(c);
            }
        }

        // Convert the StringBuilder to a string
        string newString = sb.ToString();
        // Convert to lowercase so the comparison is case-insensitive
        string lower = newString.ToLower();

        // Debug: Print original and cleaned lowercase string
        Console.WriteLine(s + " " + lower);

        // Initialize two pointers: start (i) and end (j)
        int i = 0;
        int j = lower.Length - 1;

        // Loop until the pointers meet in the middle
        while (i < j)
        {
            // Debug: Print indices being compared
            Console.WriteLine("Checking letters " + i + " and " + j);
            Console.WriteLine(lower[i] + " and " + lower[j]);

            // If characters at i and j are not equal, it's not a palindrome
            if (lower[i] != lower[j])
            {
                return false;
            }

            // Move pointers toward the center
            i++;
            j--;
        }

        // If all corresponding characters matched, it is a palindrome
        return true;
    }
}
