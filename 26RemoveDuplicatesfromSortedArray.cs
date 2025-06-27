public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1] && nums[i] != 101)
            {
                for (int x = i; x < nums.Length - 1; x++)
                {
                    nums[x] = nums[x + 1];
                    nums[x + 1] = 101;
                }
                i--;
            }
            else if (nums[i] == 101)
            {
                break;
            }
        }

        nums = nums.Where(x => x != 101).ToArray();
        int ans = Array.IndexOf(nums, 101);

        return nums.Count();
    }
}