using System.Collections.Generic;

public class LinkedListNode
{
    public int val { get; set; }
    public LinkedListNode next { get; set; }
    public LinkedListNode other { get; set; }

    public LinkedListNode(int val, LinkedListNode next = null, LinkedListNode other = null)
    {
        this.val = val;
        this.next = next;
        this.other = other;
    }
}

public class LinkedListCopy
{
    public static LinkedListNode deepCopyLinkedList(LinkedListNode root)
    {
        if (root == null) return null;
        LinkedListNode l2 = null;
        Dictionary<LinkedListNode, LinkedListNode> dict = new Dictionary<LinkedListNode, LinkedListNode>();
        LinkedListNode ptr1 = root;
        LinkedListNode ptr2 = null;

        while (ptr1 != null)
        {
            ptr2 = new LinkedListNode(ptr1.val);
            if (l2 == null)
            {
                l2 = ptr2;
            }
            dict.Add(ptr1, ptr2);
            ptr1 = ptr1.next;
        }

        foreach (KeyValuePair<LinkedListNode, LinkedListNode> kvp in dict)
        {
            kvp.Value.next = dict[kvp.Key.next];
            kvp.Value.other = dict[kvp.Key.other];
        }

        return l2;
    }
}


/*
1->2->3->4

1_old: 1_new
2_old: 2_new


*/