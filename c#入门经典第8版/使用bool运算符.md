```c#
using System;
using static System.Console;
using static System.Convert;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a integer:");
            int myInt = ToInt32(ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            WriteLine($"Integer less than 10? {isLessThan10}");
            WriteLine($"Integer btween 0 and 5? {isBetween0And5}");
            WriteLine($"Exactly one of the above is true? " +
                $"{isLessThan10 ^ isBetween0And5}");//只有一个是正确的？
            //Console.WriteLine("Hello World!");
        }
    }
}
```
