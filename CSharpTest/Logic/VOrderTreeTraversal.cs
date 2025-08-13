public class VOrderTreeTraversal {

    // Map of map of int array (Dict of dict of List)
    public List<int> TraverseVOrder(TreeNodeExt root) {
        List<int> res  = new List<int>();
        if (root == null) { return res;}
        else {
            SortedDictionary<int, SortedDictionary<int, List<int>>> map = new SortedDictionary<int, SortedDictionary<int, List<int>>>();
            root.row = 0;
            root.col = 0;
            Queue<TreeNodeExt> q = new Queue<TreeNodeExt>();
            q.Enqueue(root);
            while(q.Count > 0) {
                int qLen = q.Count;
                for (int i = 0; i < qLen; i++) {
                    TreeNodeExt node = q.Dequeue();
                    SortedDictionary<int, List<int>> mapAtCol;
                    if (map.ContainsKey(node.col)) {
                        mapAtCol = map[node.col];
                    }
                    else {
                        mapAtCol = new SortedDictionary<int, List<int>>();
                        map.Add(node.col, mapAtCol);
                    }

                    List<int> lstToInsert;
                    if (mapAtCol.ContainsKey(node.row)) {
                        lstToInsert = mapAtCol[node.row];
                    }
                    else {
                        lstToInsert = new List<int>();
                        mapAtCol.Add(node.row, lstToInsert);
                    }
                    
                    lstToInsert.Add(node.val);

                    if (node.left != null) {
                        node.left.row = node.row + 1;
                        node.left.col = node.col - 1;
                        q.Enqueue(node.left);
                    }
                    if (node.right != null) {
                        node.right.row = node.row + 1;
                        node.right.col = node.col + 1;
                        q.Enqueue(node.right);
                    }
                    
                }
            }

            foreach (KeyValuePair<int,SortedDictionary<int,List<int>>> m in map) {
                SortedDictionary<int,List<int>> mapAtCol = m.Value;
                foreach (KeyValuePair<int,List<int>> r in mapAtCol) {
                    List<int> lst = r.Value;
                    for (int k = 0; k < lst.Count; k++) {
                        res.Add(lst[k]);
                    }
                }
            }

            return res;
        }
    }
}

public class TreeNodeExt {

    public TreeNodeExt() {
    }
    public TreeNodeExt(int val) {
        this.val = val;
    }
    public int val;
    public TreeNodeExt left;
    public TreeNodeExt right;

    public int row;
    public int col;
}