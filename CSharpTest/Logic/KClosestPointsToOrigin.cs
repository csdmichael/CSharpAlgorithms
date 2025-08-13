public class KClosestPointsToOrigin{
    public int[][] GetKClosestPointsToOrigin(int[][] points, int k) {
        if (points == null || k == 0) return new int[0][];
        else if (points.Length == 0) return new int[0][];
        else {
            int[][] res = new int[k][];

            PointIndexDist[] distToO = new PointIndexDist[points.Length];
            for (int i = 0; i < points.Length; i++) {
                if (points[i].Length < 2) {
                    distToO[i] = new PointIndexDist() {};
                } else 
                {
                    distToO[i] = new PointIndexDist() {
                        distanceSq = Math.Pow(points[i][0],2) + Math.Pow(points[i][1],2),
                        index = i
                    };
                }
            }

            if (k > points.Length) {
                k = points.Length;
            }

            PointIndexDist[] closestDist =  SortDesc(distToO, k);
            for (int i = 0; i < k; i++) {
                int ptIndex = closestDist[i].index;
                res[i] = points[ptIndex];
            }
            return res;
        }
        
    }

    private PointIndexDist[] SortDesc(PointIndexDist[] distToO, int k){
        //Bubble Sort 
        int start = 0;
        while(start < distToO.Length - 1 && start < k) {
            for (int i = start; i < distToO.Length - 1; i++) {
                if (distToO[i].distanceSq > distToO[i+1].distanceSq) {
                    PointIndexDist temp = distToO[i];
                    distToO[i] = distToO[i+1];
                    distToO[i+1] = temp;
                }
            }
            start++;
        }
        return distToO;
    }
}

public class PointIndexDist{
    public int index;
    public double distanceSq;
}