public class Solution {
    public int LengthOfLastWord(string s) {
        string[] a = s.Trim().Split(' ');
        int lw = a[a.Length - 1].Length;

        return lw;
    }
}