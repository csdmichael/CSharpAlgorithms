public class DiffTwoArrays {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {

        Dictionary<int,int> d = new Dictionary<int,int>();
        for (int i = 0; i < nums1.Length; i++) {
            int curr = nums1[i];
            if (!d.ContainsKey(curr)) {
                d.Add(curr, 1);
            }
        }
        for (int j = 0; j < nums2.Length; j++) {
            int curr = nums2[j];
            if (!d.ContainsKey(curr)) {
                d.Add(curr, 2);
            }
            else {
                d[curr] = 0;
            }
        }
        IList<IList<int>> ans = new List<IList<int>>();
        IList<int> l1 = new List<int>();
        IList<int> l2 = new List<int>();
        foreach (KeyValuePair<int,int> kpv in d) {
            int curr = kpv.Key;
            if (kpv.Value == 1) {
                l1.Add(curr);
            }
            else if (kpv.Value == 2) {
                l2.Add(curr);
            }
        }

        ans.Add(l1);
        ans.Add(l2);

        return ans;
    }

}