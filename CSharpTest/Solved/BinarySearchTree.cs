using System;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }

    public Node(int value)
    {
        Value = value;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        Node current = root;

        if (current == null)

            return false;

        if (value == root.Value)

            return true;

        if (value < root.Value)
            return Contains(current.Left, value);
        else
            return Contains(current.Right, value);
    }
    /*
    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 4));
        Console.ReadLine();
    }
    */
}