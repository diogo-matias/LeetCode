public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;

        for (int i = 0; i < words.Length; i++) {
            var word1 = words[i];
            int len1 = word1.Length;

            for (int j = i + 1; j < words.Length; j++) {
                var word2 = words[j];
                int len2 = word2.Length;

                if (len1 > len2) continue;

                bool isPrefix = true;
                for (int k = 0; k < len1; k++) {
                    if (word1[k] != word2[k]) {
                        isPrefix = false;
                        break;
                    }
                }

                if (!isPrefix) continue;

                bool isSuffix = true;
                for (int k = 0; k < len1; k++) {
                    if (word1[k] != word2[len2 - len1 + k]) {
                        isSuffix = false;
                        break;
                    }
                }

                if (isSuffix) {
                    count++;
                }
            }
        }

        return count;
    }
}
