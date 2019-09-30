using System;
using System.Linq;


namespace ConsoleApp11
{
    /*题目
     * find the kth largest element in an unsorted array.
     * note that it is the kth largest element in the sorted order,
     * not the kth distinc element
     * Example:
     * Input:[3,2,1,5,6,4] and k=2
     * Output:5
     */
    public class Solution
    {
        public int FindKthLargest(int[] nums,int k)
        {
            nums = nums.OrderBy(a => a).ToArray();
            return nums[nums.Length - k];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] nums = { 3, 1, 2, 5, 7 };
            int a=sl.FindKthLargest(nums,3);
            Console.WriteLine(a);
        }
    }
}
