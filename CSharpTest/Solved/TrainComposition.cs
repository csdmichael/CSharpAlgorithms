using System;
using System.Collections.Generic;

public class TrainComposition
{
    LinkedList<int> lstTrain = new LinkedList<int>();

    public void AttachWagonFromLeft(int wagonId)
    {
        lstTrain.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        lstTrain.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        int left = lstTrain.First.Value;
        lstTrain.RemoveFirst();
        return left;
    }

    public int DetachWagonFromRight()
    {
        int right = lstTrain.Last.Value;
        lstTrain.RemoveLast();
        return right;
    }

    /*
    public static void Main(string[] args)
    {
        TrainComposition tree = new TrainComposition();
        tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13

        Console.ReadLine();
    }
    */
}