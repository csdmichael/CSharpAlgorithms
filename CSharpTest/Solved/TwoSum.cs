using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        int index1, index2;

        index1 = 0;

        if (list.Count < 2) return null;

        while (index1 < list.Count)
        {
            for (index2 = index1 + 1; index2 < list.Count; index2++)
            {
                if (list[index1] + list[index2] == sum)
                {
                    return new Tuple<int, int>(index1, index2);
                }
            }
            index1++;
        }

        return null;
    }

    /*
    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
            Console.ReadLine();
        }
    }
    */
}