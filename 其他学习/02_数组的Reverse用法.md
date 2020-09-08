```c#
using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的Reverse方法
            int[] test = new int[] { 36, 89, 76, 45, 32 };
            Array.Reverse(test);//整个数组反转
            foreach(var item in test)
            {
                Console.WriteLine(item);
            }//32,45,76,89,36
            Array.Reverse(test, 1, 3);//指定反转的长度
            Console.WriteLine("指定反转的长度后：");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
```
# 测试结果
```c#
32
45
76
89
36
指定反转的长度后：
32
89
76
45
36
```
