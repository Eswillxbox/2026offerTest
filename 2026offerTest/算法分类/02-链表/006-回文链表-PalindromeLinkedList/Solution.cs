namespace _2026offerTest.算法分类._02_链表;

/// <summary>
/// 回文链表判断
/// 难度: 简单
/// 标签: 链表, 双指针, 递归
/// </summary>
public class PalindromeLinkedList_Solution
{
    /// <summary>
    /// 判断链表是否为回文链表
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(1)
    /// </summary>
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
            return true;
        
        ListNode slow = head;
        ListNode fast = head;
        
        // 找到链表中点
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // 反转后半部分
        ListNode secondHalf = ReverseList(slow.next);
        
        // 比较前半部分和后半部分
        ListNode p1 = head;
        ListNode p2 = secondHalf;
        
        while (p1 != null && p2 != null)
        {
            if (p1.val != p2.val)
                return false;
            p1 = p1.next;
            p2 = p2.next;
        }
        
        return true;
    }
    
    /// <summary>
    /// 反转链表
    /// </summary>
    private ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
    
        while (curr != null)
        {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
    
        return prev;
    }
}
