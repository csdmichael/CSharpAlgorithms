/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class MergeLinkedLists {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null) return null;
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        ListNode list3 = null;
        ListNode ptr1 = list1;
        ListNode ptr2 = list2;
        ListNode ptr3 = null;
        while (ptr1 != null || ptr2 != null) {
            int curr = -1;
            if (ptr1 == null) {
                curr = ptr2.val;
                ptr2 = ptr2.next;
            }
            else if (ptr2 == null) {
                curr = ptr1.val;
                ptr1 = ptr1.next;
            }
            else {
                if (ptr1.val < ptr2.val) {
                    curr = ptr1.val;
                    ptr1 = ptr1.next;
                }
                else {
                    curr = ptr2.val;
                    ptr2 = ptr2.next;
                }
            }
            ListNode node = new ListNode(curr);
            if (list3 == null) {
                list3 = node;
                ptr3 = list3;
            }
            else {
                ptr3.next = node;
                ptr3 = ptr3.next;
            }
        }
        return list3;
    }
}