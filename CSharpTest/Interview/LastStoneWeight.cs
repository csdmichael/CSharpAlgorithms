public class LastStoneWeight{
    public int GetLastStoneWeight(int[] stones) {
        if (stones == null) return 0;
        if (stones.Length == 1) return stones[0];

        SortedDictionary<int,int> d = new SortedDictionary<int,int>();
        for (int i = 0; i < stones.Length; i++) {
            int curr = stones[i];
            if (d.ContainsKey(curr)) {
                d[curr]++;
            }
            else {
                d.Add(curr, 1);
            }
        }
        int countdown = stones.Length;
        while (countdown > 1) {
            int max1 = d.Keys.ElementAt(d.Count - 1);
            int max2 = (d.Keys.Count == 1 || d[max1] > 1)? d.Keys.ElementAt(d.Count - 1):d.Keys.ElementAt(d.Count - 2);

            //Remove max1
            if (d[max1] == 1) {
                d.Remove(max1);
            }
            else
            {
                d[max1]--;
            }
                
            //Remove max2
            if (d[max2] == 1) {
                d.Remove(max2);
            }
            else
            {
                d[max2]--;
            }

            if (max1 == max2) {
                
                countdown = countdown - 2;
            }
            else if (max1 > max2) {
                int curr = max1 - max2;
                if (d.ContainsKey(curr)) {
                    d[curr]++;
                }
                else {
                    d.Add(curr, 1);
                }
                countdown = countdown - 1;
            }

            else if (max1 < max2) {
                int curr = max2 - max1;
                if (d.ContainsKey(curr)) {
                    d[curr]++;
                }
                else {
                    d.Add(curr, 1);
                }
                countdown = countdown - 1;
            }
        }

        if (d.Count == 1) return d.Keys.ElementAt(0);
        else return 0;
    }

}