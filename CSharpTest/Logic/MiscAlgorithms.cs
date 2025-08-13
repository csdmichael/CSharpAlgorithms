using System.Collections.Generic;

public class MiscAlgorithms {

    //O(2^n)
    public int Fib(int x) {
        int res;

        if (x == 0) {
            res = 0;
        } else if (x == 1) {
            res = 1;
        } else {
            res = Fib(x - 1) + Fib(x - 2);
        }
        
        return res;
    }

    public int[] SolveQueries(TreeNode root, string chars, QueryOnTree[] queries) {
        int[] numOfTimes = new int[queries.Length];

        TraversePostOrder(root, chars);

        for(int i = 0; i < queries.Length; i++) {
            numOfTimes[i] = GetNumOfOccurences(root, queries[i]);
        }

        return numOfTimes;
    }

    protected void TraversePostOrder(TreeNode root, string chars) {
        if (root.left != null) {
            TraversePostOrder(root.left, chars);
        }
        if (root.right != null) {
            TraversePostOrder(root.right, chars);
        }
        //Process root
        char c = chars[root.val - 1];
        root.charsOccur.Add(c, 1);
        if (root.right != null) {
            foreach (KeyValuePair<char, int> kvp in root.right.charsOccur) {
                if (root.charsOccur.ContainsKey(kvp.Key)) {
                    root.charsOccur[kvp.Key]++;
                }
                else {
                    root.charsOccur.Add(kvp.Key, kvp.Value);
                }
            }
        }
        if (root.left != null) {
            foreach (KeyValuePair<char, int> kvp in root.left.charsOccur) {
                if (root.charsOccur.ContainsKey(kvp.Key)) {
                    root.charsOccur[kvp.Key]++;
                }
                else {
                    root.charsOccur.Add(kvp.Key, kvp.Value);
                }
            }
        }
    }

    protected int GetNumOfOccurences(TreeNode root, QueryOnTree query) {
        int numOfTimes = 0;
        numOfTimes = BFSTree(root, query);
        return numOfTimes;
    }  

    protected int BFSTree(TreeNode root, QueryOnTree query) {
        if (root == null) { return 0;}
        if (query.nodeVal == root.val) {
            if (root.charsOccur.ContainsKey(query.searchChar)) {
                return root.charsOccur[query.searchChar];
            } else {
                return 0;
            }
        } else if (query.nodeVal < root.val) {
            return BFSTree(root.left, query);
        } else if (query.nodeVal > root.val) {
            return BFSTree(root.right, query);
        }
        return 0;
    }
}

public class QueryOnTree {
    public int nodeVal;
    public char searchChar;
}

public class TreeNode {

    public TreeNode() {
        charsOccur = new Dictionary<char, int>();
    }
    public TreeNode(int val) {
        charsOccur = new Dictionary<char, int>();
        this.val = val;
    }
    public int val;
    public TreeNode left;
    public TreeNode right;
    public Dictionary<char, int> charsOccur;
}