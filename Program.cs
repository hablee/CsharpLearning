using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while((input=Console.Read())!=-1)//windows下ctr+z退出程序
            {
                //过滤换行符和回车符
                if((input!=13)&&(input!=10))
                {
                    //将读取的整数值转化为字符输出
                    Console.WriteLine("输入了字符:{0},{1}", (char)input, input);
                }
            }

            Console.Read();
        }
    }
}
