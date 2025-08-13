using System;
using System.Collections.Generic;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        List<string> uniqueNames = new List<string>();

        foreach (string n1 in names1)
        {
            bool isExist = false;
            foreach (string nu in uniqueNames)
            {
                if (n1 == nu)
                {
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                uniqueNames.Add(n1);
            }
        }

        foreach (string n2 in names2)
        {
            bool isExist = false;
            foreach (string nu in uniqueNames)
            {
                if (n2 == nu)
                {
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                uniqueNames.Add(n2);
            }
        }

        return uniqueNames.ToArray();
    }

    /*
    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
    */
}