public class Solution {
    public int MaxSum(int[] nums) {
        nums = nums.Distinct().ToArray();
        int sum = nums.Max();
        int ans = sum;
        //1. Find greatest value
        //2. Find all positive numbers in the set and add them to the sum

        for (int i = 0; i < nums.Length; i++){
            if (nums[i] > 0 && nums[i] != sum){
                ans += nums[i];
            }
        }

        return ans;
    }
}
