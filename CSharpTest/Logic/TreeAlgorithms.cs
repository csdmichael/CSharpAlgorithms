// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

public class TreeAlgorithms {
    public void TraverseBFS(Node root) {
        if (root == null) return;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        
        while (q.Count > 0) {
            int qLen = q.Count;
            
            for (int i = 0; i < qLen; i++) {
                Node currNode = q.Dequeue();
                Console.WriteLine(currNode.data);
                if (currNode.left != null) {
                    q.Enqueue(currNode.left);
                }
                if (currNode.right != null) {
                    q.Enqueue(currNode.right);
                }
            }
        }
    }

    public void TreeVisibleNodesLeft(Node root) {
        Console.WriteLine("In Tree Visible Nodes Left...");
        if (root == null) {
            return;
        }
        Queue<Node> qVisibleNode = new Queue<Node>();

        qVisibleNode.Enqueue(root);

        while (qVisibleNode.Count > 0) {
            int queueLen = qVisibleNode.Count;
            for (int i = 1; i <= queueLen; i++) {
                Node currNode = qVisibleNode.Dequeue();
                if (i == 1) {
                    Console.WriteLine(currNode.data);
                }
                if (currNode.left != null) {
                    qVisibleNode.Enqueue(currNode.left);
                }
                if (currNode.right != null) {
                    qVisibleNode.Enqueue(currNode.right);
                }
            }
        }
    }

    public void TreeVisibleNodesRight(Node root)
    {
        Console.WriteLine("In TreeVisibleNodesRight");
        if (root == null) return;
        Queue<Node> qVisibleNodes = new Queue<Node>();
        qVisibleNodes.Enqueue(root);
        while (qVisibleNodes.Count > 0) {
            int queueLen = qVisibleNodes.Count;
            for (int i = 1; i <= queueLen; i++) {
                Node currNode = qVisibleNodes.Dequeue();
                if (i == queueLen) {
                    Console.WriteLine(currNode.data);
                }
                if (currNode.left != null) {
                    qVisibleNodes.Enqueue(currNode.left);
                }
                if (currNode.right != null) {
                    qVisibleNodes.Enqueue(currNode.right);
                }
            }

        }
    }
    
 }

public class Node {
    public Node() {
    }

    public Node(string data) {
        this.data = data;
    }
    public string data {get;set;}
    public Node left {get;set;}
    public Node right {get;set;}
}
