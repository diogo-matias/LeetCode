public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;

        int incLen = 1;
        int decLen = 1;
        int maxLen = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                incLen++;
                decLen = 1;
            } else if (nums[i] < nums[i - 1]) {
                decLen++;
                incLen = 1;
            } else {
                incLen = 1;
                decLen = 1;
            }

            maxLen = Math.Max(maxLen, Math.Max(incLen, decLen));
        }

        return maxLen;
    }
}