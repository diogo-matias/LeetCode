public class Solution {
     public int MaxScore(string s) {
        int totalOnes = 0;
        foreach (char c in s)
        {
            if (c == '1') totalOnes++;
        }

        int maxScore = 0;
        int zerosLeft = 0;
        int onesRight = totalOnes;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '0') zerosLeft++;
            else onesRight--;

            int currentScore = zerosLeft + onesRight;
            if (currentScore > maxScore)
            {
                maxScore = currentScore;
            }
        }

        return maxScore;
    }
}