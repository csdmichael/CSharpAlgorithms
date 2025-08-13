public class MergeArrays {
    public int[] Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] res = new int[n+m];
        int p1 = 0, p2 = 0;
        int i = 0;
        while (i < n + m) {
            if (p1 == m) {
                res[i] = nums2[p2];
                p2++;
                i++;
            } else if (p2 == n) {
                res[i] = nums1[p1];
                p1++;
                i++;
            } else {
                if (nums1[p1] < nums2[p2]) {
                    res[i] = nums1[p1];
                    p1++;
                    i++;
                } else {
                    res[i] = nums2[p2];
                    p2++;
                    i++;
                }
            }
        }
        return res;
    }
}