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
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("What balance would you like to have?");
            targetBalance = ToDouble(ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            } while (balance < targetBalance);
            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
                $"you'll have a balance of {balance}");
        }
    }
}
```
# 改进的版本
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
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("What balance would you like to have?");
            //检查用户输入，确保目标余额大于起始余额
            do
            {
                targetBalance = ToDouble(ReadLine());
                if (targetBalance <= balance)
                    WriteLine("You must enter an amount greater than " +
                        "your current balance!\nPlease enter another value.");
            } while (targetBalance <= balance);            
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            } while (balance < targetBalance);
            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
                $"you'll have a balance of {balance}");
        }
    }
}
```
