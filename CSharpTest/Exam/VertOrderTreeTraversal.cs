public class VertOrderTreeTraversal{
    public int[] TraverseVOrder(VTreeNode root) {
        if (root == null) {
            return null;
        }
        SortedDictionary<int, SortedDictionary<int, List<int>>> dictColRow 
            = new SortedDictionary<int, SortedDictionary<int, List<int>>>();
        Queue<VTreeNode> q = new Queue<VTreeNode>();
        root.row = 0;
        root.col = 0;
        q.Enqueue(root);
        while (q.Count > 0) {
            int qLen = q.Count;
            for (int i = 0; i < qLen; i++) {
                VTreeNode curr = q.Dequeue();
                //Add node in dict
                SortedDictionary<int, List<int>> dictCol;
                if (dictColRow.ContainsKey(curr.col)) {
                    dictCol = dictColRow[curr.col];
                } else {
                    dictCol = new SortedDictionary<int, List<int>>();
                    dictColRow.Add(curr.col, dictCol);
                }
                List<int> nodes;
                if (dictCol.ContainsKey(curr.row)) {
                    nodes = dictCol[curr.row];
                }
                else {
                    nodes = new List<int>();
                    dictCol.Add(curr.row, nodes);
                }
                nodes.Add(curr.data);

                if (curr.left != null) {
                    curr.left.row = curr.row + 1;
                    curr.left.col = curr.col - 1;
                    q.Enqueue(curr.left); 
                }

                if (curr.right != null) {
                    curr.right.row = curr.row + 1;
                    curr.right.col = curr.col + 1;
                    q.Enqueue(curr.right); 
                }
            }
        }

        List<int> res = new List<int>(); 

        foreach (KeyValuePair<int, SortedDictionary<int, List<int>>> col in dictColRow) {
            foreach(KeyValuePair<int, List<int>> row in col.Value) {
                List<int> lstNodes = row.Value;
                res.AddRange(lstNodes);
            }
        }

        return res.ToArray();
    }
}

public class VTreeNode {
    public VTreeNode(int d) {
        data = d;
    }
    public int data;
    public int col;
    public int row;
    public VTreeNode left;
    public VTreeNode right;
}

// See https://aka.ms/new-console-template for more information

/*
            1                (0,0)
          /    \
        2        6        (-1,1)  (1,1) 
          \     /          
            7  3            (0,2) (0,2)
          /   \
        4       5
              /
            8   
   [2,4,1,7,3,8,6,5] 

   Time: O(N)
   Space: O(DWN)
*/