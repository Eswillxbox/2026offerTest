namespace _2026offerTest.习题集;

public class RotateRightListSolution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }
        
        ListNode p1 = head;
        int length = 1;
        
        while (p1.next != null)
        {
            p1 = p1.next;
            length++;
        }
        
        p1.next = head;
        
        int stepsToNewTail = length - (k % length);
        
        ListNode p2 = head;
        for (int i = 1; i < stepsToNewTail; i++)
        {
            p2 = p2.next;
        }
        
        head = p2.next;
        p2.next = null;
        
        return head;
    }
}
