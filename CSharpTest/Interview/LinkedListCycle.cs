// Definition for singly-linked list.
 public class ListNodeC {
     public int val;
     public ListNodeC next;
     public ListNodeC(int x) {
         val = x;
         next = null;
     }
 }
 
public class LinkedListCycle {
    public bool HasCycle(ListNodeC head) {
        if (head == null) return false;
        Dictionary<int, bool> d = new Dictionary<int,bool>();
        ListNodeC ptr = head;
        while (ptr != null) {
            if (d.ContainsKey(ptr.val)) {
                return true;
            }
            else {
                d.Add(ptr.val, true);
            }
            ptr = ptr.next;
        }
        return false;
    }
}

/*
hash
3: true
2: true
0: true
-4: true

*/
