public class Solution {
    public bool Check(int[] nums) {
       int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int next = (i + 1) % nums.Length;

            if (nums[i] > nums[next])
            {
                count++;
                if (count > 1)
                    return false;
            }
        }

        return true;
    }
}