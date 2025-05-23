public class Solution {
   public bool AreAlmostEqual(string s1, string s2) {
        if (s1.Length != s2.Length) return false;

        char[] chars = s1.ToCharArray();

        for (int i = 0; i < s1.Length; i++) {
            for (int k = i; k < s1.Length; k++) {
                
                (chars[i], chars[k]) = (chars[k], chars[i]);

                if (new string(chars) == s2) return true;

                (chars[i], chars[k]) = (chars[k], chars[i]);
            }
        }

        return false;
    }
}