public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;

        for(int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            bool isOdd = num.ToString().Length % 2 == 0;

            result = isOdd ? result + 1 : result;
        }

        return result;
    }
}