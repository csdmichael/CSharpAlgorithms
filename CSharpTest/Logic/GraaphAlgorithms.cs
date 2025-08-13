public class GraphAlgorithms {
    public void BFSGraph(int start, Graph g) {
        if (g == null) return;
        if (g.vertices.Count == 0) {
            return;
        } else {
            
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            /*
            for (int i = 0; i < g.vertices.Count; i++) {
                visited.Add(i, false);
            }
            */
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited.Add(start, true);
            while(q.Count > 0) {
                int qLen = q.Count;
                for (int i = 0; i < qLen; i++) {
                    int curr = q.Dequeue();
                    Console.WriteLine(curr);
                    if (g.vertices.ContainsKey(curr)) {
                        List<int> adj = g.vertices[curr];
                        foreach (int v in adj) {
                            if (!visited.ContainsKey(v)) {
                                q.Enqueue(v);
                                visited.Add(v, true);
                            }
                        }
                    }
                }
            }
        }
    }
}

public class Graph {
    public Dictionary<int,List<int>> vertices;
    public bool directed;

    public Graph(bool direct) {
        vertices = new Dictionary<int, List<int>>();
        directed = direct;
    }

    public void AddEdge(int v, int w) {
        if (vertices.ContainsKey(v)) {
            vertices[v].Add(w);
        } else {
            List<int> l = new List<int>();
            l.Add(w);
            vertices.Add(v, l);
        }

        if (!directed) {
            if (vertices.ContainsKey(w)) {
                vertices[w].Add(v);
            } else {
                List<int> l = new List<int>();
                l.Add(v);
                vertices.Add(w, l);
            }
        }
    }
}
