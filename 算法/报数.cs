using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*报数序列是一个整数序列，按照其中的整数的顺序进行报数，得到下一个数。其前5项如下
     * 1. 1
     * 2. 11
     * 3. 21
     * 4. 1211
     * 5. 111221
     * 解释：1 被读作 one 1,即11，11 被读作 two 1，即 21 ，21 被读作 one 2,one 1，即 1211
     * 
     * 给定一个正整数n(1<=n<=30)，输出报数序列的第n项
     * 注意：整数序列将表示为一个字符串
     * 
     * 输入：1
     * 输出：1
     * 输入：4
     * 输出：1211
     */
     public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";
            string res = "1";
            for(int i=0;i<n-1;i++)
            {
                StringBuilder buffer = new StringBuilder();
                char currentChar = default(char);
                int currentCharCount = 0;
                currentChar = res[0];

                foreach(var ch in res)
                {
                    if (ch == currentChar)
                        currentCharCount++;
                    else
                    {
                        buffer.Append(currentCharCount.ToString()).Append(currentChar);
                        currentChar = ch;
                        currentCharCount = 1;
                    }
                }
                buffer.Append(currentCharCount.ToString()).Append(currentChar);
                res = buffer.ToString();
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.CountAndSay(4));
        }
    }
}
