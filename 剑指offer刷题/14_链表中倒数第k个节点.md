# 题目描述
输入一个链表，输出该链表中倒数第k个结点。
# 代码（解析在代码中）
```c#
/*
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode (int x)
    {
        val = x;
    }
}*/
class Solution
{
    public ListNode FindKthToTail(ListNode head, int k)
    {
        // write code here
        //1-n-1
        //2-n-2
        //3-n-3
        //n-0
        //倒数第k个节点是第（n-k）个节点
        int n=0;
        ListNode re=head;//要建立一个副本节点来计算链表长度
        while(re!=null){
            n++;
            re=re.next;
        }        
        if(head == null||k<=0||k>n){
            return null;
        }
        for(int i=0;i<n-k;i++){
            head = head.next;
        }
        return head;
    }
}
```
# 测试结果
运行时间: 30ms 占用内存: 3368KB
