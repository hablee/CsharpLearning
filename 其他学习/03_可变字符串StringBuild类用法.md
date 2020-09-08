```c#
using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 368;
            //实例化一个StringBuild类，并初始化为资治通鉴
            StringBuilder sBuild = new StringBuilder("资治通鉴");
            //使用Append方法将字符串追加到sBuild末尾
            sBuild.Append(":司马光著");
            Console.WriteLine("Append之后: "+sBuild);
            //使用AppendFormat方法将字符串按照指定格式追加到sBuild末尾
            sBuild.AppendFormat("{0:C0}", Num);
            Console.WriteLine("AppendFormat之后: " + sBuild);
            //使用Insert方法将古籍追加到开头
            sBuild.Insert(0, "古籍：");
            Console.WriteLine("Insert之后：" + sBuild);
            //使用Remove从sBuild中删除索引为7之后的字符串
            sBuild.Remove(7, sBuild.Length - 7);
            Console.WriteLine("Remove之后：" + sBuild);
            //使用Replace方法将古籍替换为中国书必读系列
            sBuild.Replace("古籍", "中国书必读系列");
            Console.WriteLine("Replace之后：" + sBuild);
        }
    }
}
```
# 测试结果
```c#
Append之后: 资治通鉴:司马光著
AppendFormat之后: 资治通鉴:司马光著￥368
Insert之后：古籍：资治通鉴:司马光著￥368
Remove之后：古籍：资治通鉴
Replace之后：中国书必读系列：资治通鉴
```
