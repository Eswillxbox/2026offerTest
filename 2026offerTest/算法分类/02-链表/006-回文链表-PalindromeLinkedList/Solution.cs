namespace _2026offerTest.习题集;

public class Q1Palindrome
{
    public bool IsPalindrome(ListNode01 head)
    {
        if (head == null || head.next == null)
            return true;
        ListNode01 slow = head;
        ListNode01 fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode01 secondHalf = ReverseList(slow.next);
        
        ListNode01 p1 = head;
        ListNode01 p2 = secondHalf;
        
        while (p1 != null && p2 != null)
        {
            if (p1.val != p2.val)
                return false;
            p1 = p1.next;
            p2 = p2.next;
        }
        return true;
    }
    
    public ListNode01 ReverseList(ListNode01 head)
    {
        ListNode01 prev = null;
        ListNode01 curr = head;
    
        while (curr != null)
        {
            ListNode01 nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
    
        return prev;
    }
}

public class ListNode01 
{
    public int val;
    public ListNode01 next;
    public ListNode01(int val=0, ListNode01 next=null) 
    {
            this.val = val;
            this.next = next; 
    }
}
