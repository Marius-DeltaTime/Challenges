public class Solution {
    public int RomanToInt(string romanString) {

        Dictionary<char, int> romanDictionary = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int totalValue = 0;

        for (int i = 0; i < romanString.Length; i++)
        {
            int currentValue = romanDictionary[romanString[i]];

            if (i + 1 < romanString.Length && romanDictionary[romanString[i + 1]] > currentValue)
            {
                totalValue -= currentValue;
            }
            else
            {
                totalValue += currentValue;
            }
        }
        return totalValue;
    }
}