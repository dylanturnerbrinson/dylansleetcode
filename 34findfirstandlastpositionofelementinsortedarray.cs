public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] ans = [-1, -1];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {

                //If ans[0] hasn't been set, set it. Otherwise set ans[1].
                if (i == 0 || (i > 0 && nums[i - 1] != target))
                {
                    ans[0] = i;
                    ans[1] = i;
                }
                else
                {
                    ans[1] = i;
                }
            }
        }

        return ans;
    }
}