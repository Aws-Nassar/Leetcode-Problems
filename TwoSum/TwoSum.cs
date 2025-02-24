public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int j=0;
        for (int i = 0; i < nums.Length; i++)
        {
            j = i + 1;
            for(; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[] {i,j};
                }
            }
        }
        return new int[] {-1,-1};
    }
}
