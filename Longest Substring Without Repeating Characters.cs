public class Solution
{
    public int LengthOfLongestSubstring(string inputString)
    {
        // need to create a dictionary to store the characters and then check if the next index is inside the dictionary to elimate
        // duplicates
        Dictionary<char, int> subStringDictionary = new Dictionary<char, int>();
        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            char currentChar = inputString[i];

            if (subStringDictionary.ContainsKey(currentChar))
            {
                // move the starting pointer to the right of the last time the current character occured
                start = Math.Max(start, subStringDictionary[currentChar] + 1);
            }

            // update the character's position
            subStringDictionary[currentChar] = i;

            // calculate the length of the current substring
            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }
}
