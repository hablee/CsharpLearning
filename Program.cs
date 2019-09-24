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
            Console.Title = "我的应用程序";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("第一行文本");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("第二行文本");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("第三行文本");
            
            Console.Read();
        }
    }
}
