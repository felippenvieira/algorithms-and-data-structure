public class Solution {
    public int[] RunningSum(int[] nums) {
        var actual = 0;
        int[] ints = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            actual += nums[i];
            ints[i] = actual;
        }

        return ints;
    }
}