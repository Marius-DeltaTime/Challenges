public class Solution {
    public bool IsPalindrome(int x) {
        // create list of characters if indices of the list is the same in it's default order or the reverse order it should be a palindrome
        string numberAsString = x.ToString();
        char[] palindromeArray = numberAsString.ToCharArray();
        
        char[] reverseArray = new char[palindromeArray.Length];
        Array.Copy(palindromeArray, reverseArray, palindromeArray.Length);
        Array.Reverse(reverseArray);

        return Enumerable.SequenceEqual(palindromeArray, reverseArray);

    }
}