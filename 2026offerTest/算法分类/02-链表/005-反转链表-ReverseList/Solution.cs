namespace _2026offerTest.算法分类._02_链表;

/// <summary>
/// 链表节点定义
/// </summary>
public class ListNode
{
    public int val;
    public ListNode next;
    
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/// <summary>
/// 反转链表
/// 难度: 简单
/// 标签: 链表, 双指针
/// </summary>
public class ReverseList_Solution
{
    /// <summary>
    /// 反转单链表
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(1)
    /// </summary>
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode prev = null;
        ListNode curr = head;
        
        while (curr != null)
        {
            ListNode nextTemp = curr.next;  // 保存下一个节点
            curr.next = prev;                // 反转指针
            prev = curr;                     // 移动 prev
            curr = nextTemp;                 // 移动 curr
        }

        return prev;  // prev 成为新的头节点
    }
}
