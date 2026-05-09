namespace _2026offerTest.习题集;

public class Q1Palindrome
{
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
            return true;
        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode secondHalf = ReverseList(slow.next);
        
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
    
    public ListNode ReverseList(ListNode head)
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


