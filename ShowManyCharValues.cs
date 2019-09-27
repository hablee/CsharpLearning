using System;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            do
            {
                Console.WriteLine("输入字符并按回车,按#键结束");
                c = (char)Console.Read();
                //这忽略的两行非常重要
                Console.Read();//忽略回车换行
                Console.Read();//忽略回车换行
                Console.WriteLine("{0}的ascii码值为:{1}",c, (int)c);
            } while (c != '#');
        }
    }
}
