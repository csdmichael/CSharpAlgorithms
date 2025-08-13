public class MergeOverlappingIntervals{
    public List<Interval> MergeIntervals(Interval[] intervals) {
        if (intervals == null) {
            return null;
        } else if (intervals.Length == 0) {
            return new List<Interval>();
        } else if (intervals.Length == 1) {
            return new List<Interval>(){ intervals[0] };
        } else {
            List<Interval> res = new List<Interval>();
            int pos = 0;
            res.Add(intervals[0]);
            while (pos < intervals.Length - 1) {
                Interval curr = res[res.Count - 1];
                Interval next = intervals[pos + 1];
                if (curr.p2 >= next.p1) {
                    //Merge
                     Interval merged = new Interval() {
                        p1 = curr.p1,
                        p2 = (curr.p2 > next.p2) ? curr.p2 : next.p2
                    };
                    res[res.Count - 1] = merged;
                    pos++;
                }
                else {
                    res.Add(next);
                    pos++;
                }
                
            }
            return res;
        }
    }
}

public class Interval {
    public int p1;
    public int p2;
}