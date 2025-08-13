using NUnit.Framework.Constraints;
using System.Collections.Generic;

public class MergeOverlappingIntervalsE {
    public List<Interval> MergeIntervals(Interval[] intervals) {
        if (intervals == null) return null;
        if (intervals.Length == 0) {
            return new List<Interval>(){};
        }
        if (intervals.Length == 1) {
            return new List<Interval>(){intervals[0]};
        }

        List<Interval> lst = new List<Interval>();
        lst.Add(intervals[0]);
        for (int ptr = 1; ptr < intervals.Length; ptr++) {
            Interval currI = intervals[ptr];
            Interval lstTail = lst[lst.Count - 1];
            if (lstTail.p2 >= currI.p1) {
                //Merge
                lstTail.p2 = GetMax(lstTail.p2, currI.p2);
            } else {
                lst.Add(currI);
            }
        }

        return lst;
    }
    private int GetMax(int x, int y) {
        if (x >= y) return x;
        else return y;
    }
}



/*
[2,4] [3,8] [4,7] [9,10]
[2,8] [9,10]

List<Interval> lst
ptr to loop on input

lst
[2,8]
[9,10]

ptr 4

Time: O(N)
Space: O(N)
*/