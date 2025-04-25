public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;

        int original = x;
        int reverso = 0;

        while (x > 0)
        {
            int digito = x % 10;
            reverso = reverso * 10 + digito;
            x /= 10;
        }

        return original == reverso;
    }
}