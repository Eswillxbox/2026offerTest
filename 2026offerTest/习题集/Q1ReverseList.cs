namespace _2026offerTest.习题集;

public class Q1ReverseList
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode p1 = head;
        ListNode p2 = head.next;
        head.next = null;
        do
        {
            ListNode temp = p2.next;
            p2.next = p1;
            p1 = p2;
            p2 = temp;
        } while (p2 != null);


        return p1;
    }
}


  public class ListNode 
  {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) 
     { this.val = val; this.next = next; } 
  }
 