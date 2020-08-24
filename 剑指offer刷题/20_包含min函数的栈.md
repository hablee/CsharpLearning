# 题目描述
定义栈的数据结构，请在该类型中实现一个能够得到栈中所含最小元素的min函数（时间复杂度应为O（1））。
# 解析
复杂度为o(1)说明就不能遍历了。需要建立一个辅助栈，存最小值。为了保证辅助栈的最小值和原栈pop()之后的最小值一样，需要在辅助栈中也pop()，于是需要在push中多次添加当前最小值
# 代码
```c#
using System.Collections.Generic;
class Solution
{
    Stack<int> stack = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();
    public void push(int node) 
    {
        stack.Push(node);
        if(stack2.Count==0)
            stack2.Push(node);
        else{
            if(stack2.Peek()>node){
                stack2.Push(node);
            }else{
                stack2.Push(stack2.Peek());
            }
        }
    }
    public void pop() 
    {
        stack.Pop();
        stack2.Pop();
    }
    public int top() 
    {
        return stack.Peek();
    }
    public int min() 
    {
        return stack2.Peek();
    }
}
```
# 测试结果
运行时间: 29ms 占用内存: 3756KB
