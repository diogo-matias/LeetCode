public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        string strInverted = new String(str.Reverse().ToArray());

        return str == strInverted;
    }
}