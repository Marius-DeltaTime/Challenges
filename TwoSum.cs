public class Solution {
    // iterate through the array nums exactly once, and each lookup and insertion operation in the hashmap(dictionary) takes average constant time O(1).
    // The space complexity is O(n) because, in the worst case, we'll need to store every element of the nums in the dictionary exactly once.

    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pairing = new Dictionary<int, int>();
        int difference;
        for(int i = 0; i < nums.Length; i++)
        {
            difference = target - nums[i];
            if (pairing.ContainsKey(difference))
            {
                return new int[] { pairing[difference], i };
            }
            else
            {
                pairing[nums[i]] = i;
            }
        }
        return new int[] { };
    }
}