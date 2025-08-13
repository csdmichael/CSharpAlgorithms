public class AboveAverageSubArrays {
    public Subarray[] aboveAverageSubarrays(int[] A) {
        if (A == null) {
            return null;
        } else if (A.Length <= 1) {
            return new Subarray[] {};
        } else {
            List<Subarray> res = new List<Subarray> ();
            for (int step = 0; step < A.Length; step++) {
                for (int i = 0; i <= A.Length - step - 1; i++) {
                    double left = GetAvSum(A, i, i + step);
                    double right = GetAvSum(A, i + step + 1, A.Length - 1);
                    if (left > right) {
                        res.Add(new Subarray() {start = i + 1, end = i + 1 + step});
                    }
                }
            }
            return res.ToArray();
        }
    }

    private double GetAvSum(int[] A, int start, int end) {
        if (start > end || end >= A.Length) {
            return 0.0;
        } else {
            int dom = end - start + 1;
            int runningSum = 0;
            for (int s = start; s <= end; s++) {
                runningSum += A[s];
            }
            double av = (1.0 * runningSum) / dom;
            return av;
        }
    }
}

public class Subarray {
    public int start;
    public int end;
}