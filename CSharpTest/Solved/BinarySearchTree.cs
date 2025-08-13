using System;

public class NodeBT
{
    public int Value { get; set; }

    public NodeBT Left { get; set; }

    public NodeBT Right { get; set; }

    public NodeBT(int value, NodeBT left, NodeBT right)
    {
        Value = value;
        Left = left;
        Right = right;
    }

    public NodeBT(int value)
    {
        Value = value;
    }
}

public class BinarySearchTree
{
    public static bool Contains(NodeBT root, int value)
    {
        NodeBT current = root;

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
        NodeBT n1 = new NodeBT(1, null, null);
        NodeBT n3 = new NodeBT(3, null, null);
        NodeBT n2 = new NodeBT(2, n1, n3);

        Console.WriteLine(Contains(n2, 4));
        Console.ReadLine();
    }
    */
}