using System;
using System.Collections.Generic;

/*Design a stack that supports push, pop, top, and 
 * retrieving the minimum element in constant time.
 * 
 * push(x)--Push element x onto the stack
 * pop()-- Remove the element on top of the stack
 * top()--Get the top element
 * getMin()--Retrieve the minimum element in the stack
 * 
 */

namespace ConsoleApp9
{
    public class MinStack
    {
        //initiate your data structure here
        private readonly Stack<int> _stack;
        private readonly Stack<int> _stackMin;

        public MinStack()
        {
            _stack = new Stack<int>();
            _stackMin = new Stack<int>();
        }

        public void push(int x)
        {
            _stack.Push(x);
            if(_stackMin.Count==0||_stackMin.Peek()>=x)
            {
                _stackMin.Push(x);
            }
        }

        public void pop()
        {
            int x = _stack.Pop();
            if(_stackMin.Peek()==x)
            {
                _stackMin.Pop();
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _stackMin.Peek();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.push(-2);
            obj.push(0);
            obj.push(-3);
            int param_4 = obj.GetMin();
            Console.WriteLine(param_4);

            obj.pop();
            int param_3 = obj.Top();
            Console.WriteLine(param_3);

            int param_2 = obj.GetMin();
            Console.WriteLine(param_2);

            //Console.Read();
        }
    }
}
