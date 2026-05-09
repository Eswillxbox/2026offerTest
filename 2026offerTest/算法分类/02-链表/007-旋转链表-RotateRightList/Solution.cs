namespace _2026offerTest.算法分类._02_链表;

/// <summary>
/// 旋转链表
/// 难度: 中等
/// 标签: 链表, 双指针
/// </summary>
public class RotateRightList_Solution
{
    /// <summary>
    /// 将链表向右旋转k个位置
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(1)
    /// </summary>
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }
        
        // 计算链表长度并找到尾节点
        ListNode p1 = head;
        int length = 1;
        
        while (p1.next != null)
        {
            p1 = p1.next;
            length++;
        }
        
        // 形成环
        p1.next = head;
        
        // 计算新的尾节点位置
        int stepsToNewTail = length - (k % length);
        
        // 找到新的尾节点
        ListNode p2 = head;
        for (int i = 1; i < stepsToNewTail; i++)
        {
            p2 = p2.next;
        }
        
        // 断开环，形成新的头节点
        head = p2.next;
        p2.next = null;
        
        return head;
    }
}
