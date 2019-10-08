using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /*Given an array nums of n integers where n>1, return an array output[i]
     * is equal to the product of all the elements of nums except nums[i]
     * 
     * Example:
     * Input:[1,2,3,4]
     * Output:[24,12,8,6]
     * 
     * Note:Please solve it without division and in O(n)
     * 
     */
     public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            int[] output1 = new int[len];//正向乘积
            int[] output2 = new int[len];//反向乘积
            output1[0] = 1;
            output2[len - 1] = 1;
            for(int i=1;i<len;i++)
            {
                output1[i] = output1[i - 1] * nums[i - 1];
                output2[len - 1 - i] = output2[len - i] * nums[len - i];

            }
            for(int i=0;i<len;i++)
            {
                output1[i] *= output2[i];
            }
            return output1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] re=sl.ProductExceptSelf(nums);
            foreach(int re1 in re)
            {
                Console.WriteLine(re1);
            }
        }
    }
}
