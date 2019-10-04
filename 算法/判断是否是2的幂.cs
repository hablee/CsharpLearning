using System;


namespace ConsoleApp2
{
    /*Given an integer, write a function to determine if it is
     * a power of two
     * Example:
     * Input:1
     * Output:true
     * 
     * Example:
     * Input:218
     * Output:false
     */
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n < 1)
                return false;
            if (n == 1)
                return true;
            int a = n >> 1;
            while(a!=1)
            {
                if (a << 1 != n)
                    return false;
                n = a;
                a = n >> 1;
            }
            return a << 1 == n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            bool re = sl.IsPowerOfTwo(123);
            Console.WriteLine(re);
        }
    }
}
