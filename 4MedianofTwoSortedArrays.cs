public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

/* 4. Median of Two Sorted Arrays
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
*/
        int[] merged_arrays = nums1.Concat(nums2).ToArray();
        Array.Sort(merged_arrays);

        int med = merged_arrays.Length/2;

        if (merged_arrays.Length%2 != 0){
            return merged_arrays[merged_arrays.Length/2];
        } else {
            return ((double)(merged_arrays[med-1]+merged_arrays[med])/2);
        }
    }
}