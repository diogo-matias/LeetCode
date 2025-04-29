public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        

        for (int i = 0; i < (nums.Length * nums.Length); i++)
        {  
            int ii = i % nums.Length;
            int cycle = i / nums.Length;
            int iNext = ii + 1 + cycle;
            
            if (iNext < nums.Length){
                int num = nums[ii];
                int next = nums[iNext];
                if (num + next == target){
                    return [ii, iNext];
                }
            }
        }

        return [0, 0];
    }
}