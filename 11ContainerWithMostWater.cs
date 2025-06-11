/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.
*/

using System.Threading.Tasks;

public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;

        while(left < right){
            int h = Math.Min(height[left], height[right]);
            int l = Int32.Abs(left-right);
            max = Math.Max(max, h * l);

            if (height[left] < height[right]){
                left++;
            } else {
                right--;
            }
        }

        return max;
    }

}