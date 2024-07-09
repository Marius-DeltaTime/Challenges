// Given a string inputString, find the length of the longest substring without repeating characters.

public class Solution {
    public int LengthOfLongestSubstring(string inputString) 
    {
        string substring = "";
        int substringCount = 0;
        List<char> nonRepeatingCharacters = new List<char>();
        //if the character is not the same as the previous character add both to a tracker 

        for(int i = 0; i < inputString.Length; i++)
        {
            if (i + 1 < inputString.Length && inputString[i] != inputString[i + 1])
            {
                substring += inputString[i];
                substringCount++;
            }
        }

        return substringCount;
    }
}