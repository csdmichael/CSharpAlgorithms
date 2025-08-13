public class ReverseSingleList {
    public ListNode ReverseList(ListNode head) {
        if (head == null) return null;
        Stack<int> s = new Stack<int>();

        ListNode ptr = head;
        while(ptr != null) {
            s.Push(ptr.val);
            ptr = ptr.next;
        }

        ListNode res = null;
        ListNode ptr2 = null;
        while (s.Count > 0) {
            int curr = s.Pop();
            if (res == null) {
                res = new ListNode(curr);
                ptr2 = res;
            } else {
                ptr2.next = new ListNode(curr);
                ptr2 = ptr2.next;
            }
        }

        return res;
    }
}

public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }

 /*
Given the head of a singly linked list, reverse the list, and return the reversed list.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
 

Constraints:

The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 */