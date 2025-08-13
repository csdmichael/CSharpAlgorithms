public class TreeToLinkedList {
    public void TraverseTree(TNode root, ref LList list) {
        if (root == null) { return;}
        else {
            if (root.left != null) {
                TraverseTree(root.left, ref list);
            }
            list.AddNode(root.data);
            if (root.right != null) {
                TraverseTree(root.right, ref list);
            }
        }
    }
    public LList TransformTreeToList(TNode root) {
        if (root == null) { return null; } 
        else {
            LList list = new LList();
            TraverseTree(root, ref list);
            return list;
        }
    }
}

public class TNode {
    public TNode(int d) {
        data = d;
    }
    public int data;
    public TNode left;
    public TNode right;
}
public class LList {
    public LNode head;
    public LNode tail;

    public void AddNode(int d) {
        if (head == null) {
            head = new LNode(d);
            tail = head;
        } else {
            LNode n = new LNode(d);
            tail.next = n;
            n.prev = tail;
            tail = n;
        }
    }
}

public class LNode {
    public LNode(int d) {
        this.data = d;
    }
    public int data;
    public LNode prev;
    public LNode next;

}