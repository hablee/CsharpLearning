using System;
using System.Collections.Generic;



namespace ConsoleApp1
{
    /*
     * Given an array of integers, find if the array contains any duplicates.
     * Your function should return ture if any value appears at least twice in the
     * array, and it should return false if every element is distinct.
     * 
     * Example:
     * Input:[1,2,3,1,2]
     * Output:true
     * Input:[1,2,3,4]
     * Output:false
     * 
     */
     public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2)
                return true;
            HashSet<int> h = new HashSet<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (h.Contains(nums[i]))
                    return true;
                h.Add(nums[i]);
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] nums = { 1, 2, 3, 4,  };

            bool re = sl.ContainsDuplicate(nums);
            Console.WriteLine(re);

        }
    }
}
