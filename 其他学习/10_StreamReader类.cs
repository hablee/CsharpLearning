using System;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //创建一个StreamReader的实例来读取文件
                //using语句也能关闭StreamReader
                using (StreamReader sr = new StreamReader(@"C:\Users\MNEgroup\Documents\jamaica.txt"))
                {
                    string line;
                    //从文件读取并显示行，直到文件的末尾
                    while((line=sr.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                //向用户显示出错信息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
//*jamaica.txt
/* 

Down the way where the nights are gay
And the sun shines daily on the mountain top
I took a trip on a sailing ship
And when I reached Jamaica
I made a stop

*/
