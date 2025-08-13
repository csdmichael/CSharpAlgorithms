using System.Collections.Generic;

public class LinkedListNodeBT
{
    public int val { get; set; }
    public LinkedListNodeBT next { get; set; }
    public LinkedListNodeBT other { get; set; }

    public LinkedListNodeBT(int val, LinkedListNodeBT next = null, LinkedListNodeBT other = null)
    {
        this.val = val;
        this.next = next;
        this.other = other;
    }
}

public class LinkedListCopy
{
    public static LinkedListNodeBT deepCopyLinkedList(LinkedListNodeBT root)
    {
        if (root == null) return null;
        LinkedListNodeBT l2 = null;
        Dictionary<LinkedListNodeBT, LinkedListNodeBT> dict = new Dictionary<LinkedListNodeBT, LinkedListNodeBT>();
        LinkedListNodeBT ptr1 = root;
        LinkedListNodeBT ptr2 = null;

        while (ptr1 != null)
        {
            ptr2 = new LinkedListNodeBT(ptr1.val);
            if (l2 == null)
            {
                l2 = ptr2;
            }
            dict.Add(ptr1, ptr2);
            ptr1 = ptr1.next;
        }

        foreach (KeyValuePair<LinkedListNodeBT, LinkedListNodeBT> kvp in dict)
        {
            if (kvp.Key.next == null)
            {
                kvp.Value.next = null;
            }
            else
            {
                kvp.Value.next = dict[kvp.Key.next];
            }
                
            if (kvp.Key.other == null)
            {
                kvp.Value.other = null;
            }
            else
            {
                kvp.Value.other = dict[kvp.Key.other];
            }
        }

        return l2;
    }
}


/*
1->2->3->4

1_old: 1_new
2_old: 2_new


*/