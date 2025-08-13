using CSharpTest.Solved;
using System;
using System.Collections.Generic;

public class DisposableWrapper : IDisposable
{
    public DisposableWrapper(IDisposable unmanagedResource) { }

    public void Dispose()
    {
        //Dispose(true);
        GC.SuppressFinalize(this);
    }

    // The bulk of the clean-up code is implemented in Dispose(bool)
    /*
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            // free managed resources
            if (managedResource != null)
            {
                managedResource.Dispose();
                managedResource = null;
            }
        }
        // free native resources if there are any.
        if (nativeResource != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(nativeResource);
            nativeResource = IntPtr.Zero;
        }
    }
    
    */
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedListNode n4 = new LinkedListNode(4);
        LinkedListNode n3 = new LinkedListNode(3, n4);
        LinkedListNode n2 = new LinkedListNode(2, n3);
        LinkedListNode r = new LinkedListNode(1, n2);
        r.other = n4;
        n2.other = n3;
        LinkedListNode output = LinkedListCopy.deepCopyLinkedList(r);
        int x = 0;

        /*
        Node root = new Node(10);
        root.Left = new Node(2);
        root.Right = new Node(3);
        root.Left.Left = new Node(7);
        root.Left.Right = new Node(8);
        root.Right.Right = new Node(15);
        root.Right.Left = new Node(12);
        root.Right.Right.Left = new Node(14);
   

        //BFS_Tree.RightTree(root);
        BFS_Tree.LeftTree(root);
        */
        Console.ReadLine();
    }
}