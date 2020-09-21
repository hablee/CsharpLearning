using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 2, 4, 1, 68, 43, 21 };
            int temp = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                //外层循环控制比较多少趟
                for(int j=0;j<arr.Length-1-i;j++)
                    //内层循环控制每趟比较多少次
                {
                    if(arr[j]>arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var ar in arr)
            {
                Console.Write(ar + " ");
            }
        }
        
    }
}
