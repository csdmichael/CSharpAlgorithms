public class MinCostAllPoints {
    public int MinCostConnectPoints(int[][] points) {
        List<Edge> lstDist = new List<Edge>();
        for(int i = 0; i < points.Length - 1; i++) {
            for (int j = i+1; j < points.Length; j++) {
                int[] pt1 = points[i];
                int[] pt2 = points[j];
                int dist = CalcDist(pt1, pt2);
                Edge e = new Edge(pt1,pt2);
                e.dist = dist;
                lstDist.Add(e);
            }
        }
        lstDist = lstDist.OrderBy(x=>x.dist).ToList();


        int minCost = 0;
        List<Edge> lstEdges = new List<Edge>();
        int index = 0;
        //Loop on edges and find min ones that does not cause cycle until 
        while (lstEdges.Count < points.Length - 1) {
            Edge currE = lstDist[index];
            int dist = lstDist[index].dist;
            if (lstEdges.Count == 0 || !IsCycle(lstEdges, currE)) {
                lstEdges.Add(currE);
                minCost += dist;
            } 
            index++;
        }

        return minCost;
    }

    private bool IsCycle(List<Edge> lstEdges, Edge e) {
        int pointsMet = 0;
        for (int i = 0; i < lstEdges.Count; i++) {
            Edge edge = lstEdges[i];
            if (
                (e.point1[0] == edge.point1[0] && e.point1[1] == edge.point1[1]) || 
                (e.point2[0] == edge.point2[0] && e.point2[1] == edge.point2[1]) || 
                (e.point1[0] == edge.point2[0] && e.point1[1] == edge.point2[1]) || 
                (e.point2[0] == edge.point1[0] && e.point2[1] == edge.point1[1])
             ) {
                pointsMet++;
                if (pointsMet > 1) return true; 
            }
        }
        if (pointsMet > 1) return true; 
        else return false;
    }

    private int CalcDist(int[] p1, int[] p2) {
        int xDelta = Math.Abs(p1[0] - p2[0]);
        int yDelta = Math.Abs(p1[1] - p2[1]);
        return xDelta + yDelta;
    }
}

public class Edge{
    public int[] point1;
    public int[] point2;
    public int dist;
    public Edge(int[] p1, int[] p2) {
        this.point1 = p1;
        this.point2 = p2;
    }
}
